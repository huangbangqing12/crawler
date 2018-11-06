#pragma once

#include "Tool.h"

class XLDownloader {
public:
	XLDownloader();

	int Download(const char* url);

protected:
	std::string thunder_path;

private:
	SHELLEXECUTEINFO shellInfo;
};