#pragma once

#include "stdafx.h"


#define LOGS_ENABLED        0


#if LOGS_ENABLED
    void LogInitialize();
    void LogPrint(TCHAR *message);
#else
#   define LogInitialize()                  // do nothing
#   define LogPrint(message)                // do nothing
#endif

void DisableConsolePrinting();

// prints given message directly to console and log file
void PrintMessage(LPCTSTR format, ...);
// print predefined 
void PrintError(LPCTSTR lpszFunctionName, DWORD lastError);
void ShowMessage(LPCTSTR lpszFunctionName, DWORD lastError, LPCTSTR arguments);
