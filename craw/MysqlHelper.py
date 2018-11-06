import os
import pymysql


class PathHelper:

    @staticmethod
    def path_exists(path):
        if path is not None:
            return os.path.exists(path)
        return False

    @staticmethod
    def dir_create(dir_path):
        if dir_path is not None and not PathHelper().path_exists(dir_path):
            os.makedirs(dir_path)
        pass

    @staticmethod
    def file_size(path):
        if PathHelper().path_exists(path):
            return os.path.getsize(path)
        return 0

    pass


class MySqlHelper:

    def __init__(self):
        self.db = pymysql.connect("192.168.5.130", "lk", "lk123456", "craw_db")
        self.cursor = self.db.cursor()
        pass

    def select_task(self):
        data = None
        try:
            sql = "select * from task_tb where delete_flag = 0 and craw_flag = 0 limit 1"
            self.cursor.execute(sql)
            data = self.cursor.fetchone()
        except BaseException as ex:
            pass
        finally:
            self.close()
        
        return data

    def insert_task(self,d):
        try:
            sql = "insert into task_tb(url,mark,type,link_reg,next_reg) values(%s,%s,%s,%s,%s)"
            self.cursor.execute(sql,[d[1],d[2],d[3],d[4],d[5]])
            self.db.commit()
        except BaseException as ex:
            print(ex)
            self.db.rollback()
        finally:
            self.close()

    def select_link(self):
        data = None
        try:
            sql = "select * from link_tb where delete_flag = 0 and craw_flag = 0 limit 1"
            self.cursor.execute(sql)
            data = self.cursor.fetchone()
        except BaseException as ex:
            print(ex)
        finally:
            self.close()
        
        return data

    def insert_link(self,url,link_list):
        try:
            sql = "insert into link_tb(url,href) values(%s,%s)"
            for link in link_list:
                self.cursor.execute(sql,[url,link])

            update = "update task_tb set craw_flag = 1 where url = %s "
            self.cursor.execute(update,url)

            self.db.commit()
        except BaseException as ex:
            print(ex)
            self.db.rollback()
            pass
        finally:
            self.close()
        pass
    
    def insert_src(self,url,href_list):
        try:
            sql = "insert into src_tb(href) values(%s)"
            for h in href_list:
                self.cursor.execute(sql,[h])

            update = "update link_tb set craw_flag = 1 where href = %s "
            self.cursor.execute(update,url)

            self.db.commit()
        except BaseException as ex:
            print(ex)
            self.db.rollback()
            pass
        finally:
            self.close()
        pass

    def close(self):
        self.cursor.close()
        self.db.close()
        pass

    pass


if __name__ == "__main__":
    datas = MySqlHelper().select_task()
    print(datas)

