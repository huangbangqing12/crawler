#pragma once

#include "cppconn\driver.h"
#include "cppconn\exception.h"
#include "cppconn\resultset.h"
#include "cppconn\statement.h"
#include "cppconn\prepared_statement.h"
#include "cppconn\\connection.h"


#include <iostream>
#include <string>
class MysqlHelper {
public:
	MysqlHelper();

	MysqlHelper& Init();

	sql::ResultSet* select();

	void update(const char* href);

	~MysqlHelper();

protected:
	sql::Driver* driver;
	sql::Connection* con;

};
