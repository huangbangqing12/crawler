
import urllib
import MysqlHelper
import socket
import gzip
import sys



class Httphelper:
    def __init__(self,url):
        self.url = url
        pass

    def __valid_url(self):
        if self.url is None:
            return False
        if str(self.url).find("http") == -1:
            return False
        if str(self.url).find("://") == -1:
            return False
        return True

    def ___build_headers(self):
        i = str(self.url).find("://")
        host = self.url[i+3:str(self.url).find("/",i+3) ]

        headers = dict()
        headers["user-agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3534.4 Safari/537.36"
        headers["host"] = host
        headers["connection"] = "keep-alive"
        headers["accept-encoding"] = "gzip, deflate"
        return headers

    def get_html(self):
        html = None
        try:
            eurl = urllib.parse.quote_plus(self.url,safe=":/?#")
            eheaders = self.___build_headers()
            req = urllib.request.Request(eurl,headers=eheaders)
            
            res = urllib.request.urlopen(req,timeout=15)
            html = res.read()
            if res.info().get("Content-Encoding") == "gzip":
                html = gzip.decompress(html).decode("utf-8")

            res.close()
        except socket.timeout:
            #print("socket timeout: {}".format(self.url))
            return self.get_html()
        except urllib.error.URLError:
            pass
        
        return html

    pass


if __name__ == "__main__":
    pass