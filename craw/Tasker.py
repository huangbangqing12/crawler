import sys
import MysqlHelper
import HttpHelper
import json
import bs4

class Tasker:
    def __init__(self):
        self.task = MysqlHelper.MySqlHelper().select_task()
        pass
    
    def __get_url(self):
        if self.task is not None:
            return self.task[1]
        return None

    def __get_link_reg(self):
        if self.task is not None:
            return json.loads(self.task[4])
        return None

    def __get_next_reg(self):
        if self.task is not None:
            return json.loads(self.task[5])
        return None

    def parse_html(self):
        try:
            url = self.__get_url()
            if url is None:
                print("task over")
                sys.exit(0)

            dom = HttpHelper.Httphelper(url).get_html()
            #@html ==> page links ====> next html ====> @html    
            if dom is not None:
                soup = bs4.BeautifulSoup(dom,"html.parser")
                link_list = self.__parse_link_list(soup,self.__get_link_reg())
                next_html_link = self.__parse_next_html(soup,self.__get_next_reg())               

                if len(link_list):
                    ll = []
                    for link in link_list:
                        ll.append(Tasker().href_add_host(url,link))
                    MysqlHelper.MySqlHelper().insert_link(url,ll)
                
                if next_html_link is not None:
                    task = list(self.task)
                    task[1] = Tasker().href_add_host(url,next_html_link)
                    MysqlHelper.MySqlHelper().insert_task(task)

        except:
            pass
    

    @staticmethod
    def href_add_host(url,href):
        if url is not None and href is not None:
            if str(href).find("http") == -1:
                i = str(url).find("://")
                host = str(url)[:str(url).find("/",i+3)]
                href = host + href

        return href

    def __parse_link_list(self,soup,reg):
        link_list = []
        try:
            for tag in soup.find_all(attrs={"class":reg["div_class"]}):
                for link in tag.find_all("a"):
                    link_list.append(link['href'])
        except BaseException:
            pass
        finally:
            return link_list

    def __parse_next_html(self,soup,reg):
        try:
            for tag in soup.find_all(attrs={"class":reg["page_class"]}):
                for link in tag.find_all("a"):
                    if link.text.find(reg["page_str"]) != -1:
                        return link['href']
        except BaseException:
            return None

    pass

if __name__ == "__main__":
    Tasker().parse_html()
    
        