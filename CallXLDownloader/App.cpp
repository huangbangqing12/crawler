#include "XLDownloader.h"
#include "MysqlHeleper.h"
#include <thread>

#pragma comment(lib,"lib\\mysqlcppconn.lib")

int main(int argc, char* const argv[]) {

	MysqlHelper mysql;
	XLDownloader d;
	mysql.Init();
	
	sql::ResultSet* res = mysql.select();
	if (res == nullptr) {
		std::cout << "connect error\n";
		return 0;
	}

	while (res->next())
	{
		sql::SQLString url = res->getString("href");
		if (d.Download(url.c_str())) {
			mysql.update(url.c_str());
		}
	}
	
}