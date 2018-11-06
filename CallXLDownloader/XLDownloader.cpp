#include "XLDownloader.h"

XLDownloader::XLDownloader()
{
	this->shellInfo = { 0 };
	this->shellInfo.cbSize = sizeof(this->shellInfo);
	this->shellInfo.fMask = SEE_MASK_NOCLOSEPROCESS;

	thunder_path = "D:\\Ñ¸À×\\Program\\Thunder.exe";
}

int XLDownloader::Download(const char * url)
{
	int downoloaded = 1;
	try
	{
		this->shellInfo.lpFile = Char2_Wchar(this->thunder_path.c_str());
		this->shellInfo.lpParameters = Char2_Wchar(url);

		ShellExecuteEx(&this->shellInfo);
		WaitForSingleObject(this->shellInfo.hProcess, INFINITE);
	}
	catch (const std::exception&)
	{
		downoloaded = 0;
	}
	
	return downoloaded;
}
