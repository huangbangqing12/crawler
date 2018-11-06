1、代码工作在win10  vs2015 c++11 环境下
2、cppconn 为mysql/c++连接的依赖头文件
    lib下面的lib文件为静态链接库
    dll下面的dll文件为动态链接库
    
3、主入口在App.cpp

4、结构
    App.cpp -----
                |--> XLDownloader.h
                |
                |--> MySqlHelper.h
                |
                |--> Tool.h
5、运行说明
    程序编译生成的exe文件，例如命名为App.exe
    
    则运行文件夹结构
    PWD----------
                | --> App.exe
                |
                | --> dll文件夹下的所有dll