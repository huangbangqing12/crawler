#include "Tool.h"

wchar_t* Char2_Wchar(const char* src) 
{
	int size = MultiByteToWideChar(CP_ACP, 0, src, -1, NULL, 0);
	wchar_t* dst = new wchar_t[size];
	MultiByteToWideChar(CP_ACP, 0, src, -1, dst, size);

	return dst;
}