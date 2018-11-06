#include "MysqlHeleper.h"

MysqlHelper::MysqlHelper()
{
	this->driver = get_driver_instance();
	this->con = nullptr;
}

MysqlHelper & MysqlHelper::Init()
{
	// TODO: 在此处插入 return 语句
	try
	{
		this->con = this->driver->connect("tcp://192.168.5.130:3306", "lk", "lk123456");
		this->con->setSchema("craw_db");
	}
	catch (const std::exception& ex)
	{
		std::cout << ex.what() << std::endl;
	}
	
	return *this;
}

sql::ResultSet * MysqlHelper::select()
{
	sql::ResultSet *res = nullptr;
	try
	{
		sql::PreparedStatement* statement = this->con->prepareStatement("select * from src_tb where flag = 0 limit 10");
		res = statement->executeQuery();
	}
	catch (const std::exception& ex)
	{
		std::cout << ex.what() << std::endl;
	}
	return res;
}

void MysqlHelper::update(const char* href)
{
	try
	{
		char buff[256] = { 0 };
		sprintf_s(buff, 256, "update src_tb set flag = 1 where href = '%s' ", href);
		sql::PreparedStatement* statement = this->con->prepareStatement(buff);
		statement->executeQuery();
	}
	catch (const std::exception& ex)
	{
		std::cout << ex.what() << std::endl;
	}
}



MysqlHelper::~MysqlHelper()
{
	delete this->con;
}
