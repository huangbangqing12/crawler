import sys
import MysqlHelper
import HttpHelper
import json
import bs4

class Linker:
    def __init__(self):
        self.link = MysqlHelper.MySqlHelper().select_link()
        pass
    
    def __get_url(self):
        if self.link is not None:
            return self.link[2]
        return None

    def __get_link_reg(self):
        if self.link is not None:
            return json.loads(self.link[4])
        return None


    def parse_html(self):
        try:
            url = self.__get_url()
            reg =self.__get_link_reg()
            if url is None or reg is None:
                print("task over")
                sys.exit(0)

            dom = HttpHelper.Httphelper(url).get_html()
            
            if dom is not None:
                soup = bs4.BeautifulSoup(dom,"html.parser")
                src_list = []
                try:
                    for tag in soup.find_all(attrs={"class":reg["div_class"]}):
                        for img in tag.find_all(reg["img_label"]):
                            src_list.append(img[reg["img_src"]])
                except :
                    pass
                
                if len(src_list):
                    MysqlHelper.MySqlHelper().insert_src(url,src_list)

        except BaseException as ex:
            print(ex)
    

    pass

if __name__ == "__main__":
    Linker().parse_html()
    
        