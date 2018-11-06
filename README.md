# crawler
python爬虫、C#winform、c++调用迅雷下载、mysql数据库


  项目流程:
  windows:  C# winform爬虫助手录入网站的【URL、页面解析规则、任务解析规则】 ===============> Mysql存储
  linux:    python3 读取Mysql存储的URL及解析规则，爬取【资源链接地址】      ===============> Mysql存储
  windows:  c++ 读取Mysql存储的资源链接地址，【调用迅雷进行下载】           ===============> 指定位置存储
  
项目技术：
  本项目需要配置的环境较多:
  linux:    安装Mysql服务器、python3
  windows:  安装vs2015,勾选有c++和C#、Mysql的workbench
  
  Mysql配置：
    支持中文: 1、安装[sudo apt install mysql-client]
              2、在mysql的配置文件[/etc/mysql/my.cnf]下面添加
                [mysqld]
        　　　　character_set_server = utf8
        　　　　[client]
        　　　　default-character-set = utf8
        　　　　[mysql]
        　　　　default-character-set = utf8
              3、重启mysql服务 [sudo service mysql restart](可以先stop再start]
              
    sudo 创建用户格式 'user_name'@'%'   [%指定任意ip可以访问]
    sudo 授权用户使用数据库  
            grant all on databse_name.* to 'user_name'@'%'; 
            flush privileges;
            use mysql; update user set host='%' where user='root';
  
  iptables配置:
    创建 sudo touch /etc/network/iptables.up.rules文件
    添加-A INPUT -p tcp -m tcp --dport 3306 -j ACCEPT支持3306端口访问
    在 /etc/network/interface文件下面添加 pre-up iptables-restore < /etc/network/iptables.up.rules 用于恢复
    然后reboot
    
  Python3配置:
    安装python3、pip、requests库、beautifulsoup4、PyMySQL, 配合vscode编辑器最好
    
  c++ && c#配置:
    安装vs2015，勾选c++和C#
    
  Mysql workbench:
    官网下载安装
    
  技术点:
    python3:
        urllib库： 设置HTTP请求头、超时；进行请求读取响应数据
        异常: 处理超时重试、其他URL异常跳过
        bs4库:   主要是解析dom的规则，需要熟悉html和css语法
        Mysql数据库的连接: PyMySQL库，非常简单
        
    C# winform:
        窗体程序的布局、事件的响应
        Mysql.Data包连接数据库，非常容易，跟ADO.NET很类似
        Dapper： 精简高效的ORM框架，支持原生sql以及实体的读取，避免自己利用反射写一个ORM
        
    C++ 调用迅雷下载:
        使用过2种方案
        1、下载迅雷下载引擎api开发包，然后进行调用下载，但是使用过程中出现bug: 对于迅雷处理过的url无法进行解析构建新任务
            而且下载不稳定
            原因分析: 引擎api包不是最新的，貌似是这样的
            
        2、windows安装最新的迅雷，c++使用ShellExecute直接调用迅雷下载的exe文件进行下载，完美支持各种链接的url、
            核心是一个ShellExecute,需要配置对迅雷下载器的exe的路径，然后将url参数传递过去就行
            再配置好迅雷的设置，可以达到秒下载多个资源
            
        3、对于不使用python3下载资源，注意考虑到虚拟机里面的linux网络和内存的原因，还有下载速度慢
        
    c++ 连接Mysql:
        官网下载Mysql connector/c++
            这个库的本质：使用jdbc的大部分规范用c++实现的；因此使用的头文件位于jdbc下面的cppconn文件夹
            按照官网例子进行调用就行了
            
            静态链接库需要配置mysqlcppconn.lib
            动态链接库需要和exe文件放在一起，需要三个: libeay32.dll、mysqlcppconn-7-vs14.dll、ssleay32.dll
            
未来展望:
    C# mvc网站后台
    C++ 多线程、多进程；高效事件驱动；服务器
    python3: 爬虫
    
    库:
        Dapper
        libevent
        python的爬虫框架
        ....
    
    
  
    
    
    
  
        
