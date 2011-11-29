//regRW.cpp

#include "stdafx.h"
#include "registry.h"
#include "task.h"
#include "regRW.h"
#include "./common/nclog.h"

//CTask _ctasks[10];

TASK _Tasks[iMaxTasks];
int iTaskCount=0;

DWORD _dwVersion = 228L;

TCHAR* _szRegKey = L"Software\\tasker";
TCHAR _szRegSubKeys[10][MAX_PATH];

int getTaskNumber(TCHAR* _sTask){
	TCHAR* sTemp = new TCHAR[wcslen(_sTask)+1];
	int iPos = wcslen(_sTask) - wcslen(L"Task");
	sTemp=&_sTask[wcslen(L"Task")];
	wcscat(sTemp, L"\0");
	int iRet = _wtoi(sTemp);
	return iRet-1;
}


///convert a HourMinute string (ie "1423) to a systemtime
int getSTfromString(SYSTEMTIME* sysTime /*in,out*/, TCHAR* sStr /*in*/){
	DWORD dbgLevel=regReadDbgLevel();

	if(dbgLevel>4) nclog(L"getSTfromString: ...\n");
	int iRet=-1;
	if(wcslen(sStr)!=4){
		if(dbgLevel>4) nclog(L"getSTfromString: failure, string len not equal to 4\n");
		return -1;	//string to short
	}
	extern SYSTEMTIME g_CurrentStartTime;
	memcpy(sysTime, &g_CurrentStartTime, sizeof(SYSTEMTIME));
	//GetLocalTime(sysTime); //v2.28
	int iTime = _wtoi(sStr);
	if(iTime == 0)
		return -2;	//string not a number
	int iHour = iTime/100;
	int iMinute = iTime % 100;
	sysTime->wHour=iHour;
	sysTime->wMinute=iMinute;
	if(dbgLevel>4) nclog(L"getSTfromString: return with '%s'\n", sStr);
	return 0;
}

///convert a systemtime to a HourMinute string (ie "1423")
int getStrFromSysTime(SYSTEMTIME sysTime, TCHAR sStr[4+1]){
	DWORD dbgLevel=regReadDbgLevel();
	if(dbgLevel>4) nclog(L"getSTfromString2: ...\n");
	int iRet=-1;
	if(wcslen(sStr)!=4){
		if(dbgLevel>4) nclog(L"getSTfromString2: failure, string len not equal to 4\n");
		return -1;	//string to short
	}
	TCHAR sTemp[4+1];
	wsprintf(sTemp, L"%02i%02i", sysTime.wHour, sysTime.wMinute);
	if(wcsncpy(sStr, sTemp, 4)==NULL){
		if(dbgLevel>4) nclog(L"getSTfromString2: returning with error for '%s'\n", sTemp);
		return -1;
	}
	else{
		if(dbgLevel>4) nclog(L"getSTfromString2: returning with '%s'\n", sStr);
		return 0; //no Error
	}
}

///convert a YearMonthDayHourMinute string (ie "201110201423) to a systemtime
int getSTfromLongString(SYSTEMTIME * sysTime /*in,out*/, TCHAR* sStr /*in*/){
	int iRet=-1;
	if(wcslen(sStr) != 12){
		return -1;	//string to short
	}
	extern SYSTEMTIME g_CurrentStartTime;
	memcpy(sysTime, &g_CurrentStartTime, sizeof(SYSTEMTIME));
	//GetLocalTime(sysTime); //v2.28
	//
	TCHAR* pStr = sStr;
	TCHAR sYear[MAX_PATH];
	int iYear = -1;
	TCHAR sMonth[MAX_PATH];
	int iMonth = -1;
	TCHAR sDay[MAX_PATH];
	int iDay = -1;
	TCHAR sHour[MAX_PATH];
	int iHour = -1;
	TCHAR sMinute[MAX_PATH];
	int iMinute = -1;

	wcsncpy(sYear, pStr, 4);	pStr+=4;
	wcsncpy(sMonth, pStr, 2);		pStr+=2;
	wcsncpy(sDay, pStr, 2);	pStr+=2;
	wcsncpy(sHour, pStr, 2);	pStr+=2;
	wcsncpy(sMinute, pStr, 2);	pStr+=4;

	if((iYear=_wtoi(sYear))<0)
		return -11;
	if((iMonth=_wtoi(sMonth))<0)
		return -12;
	if((iDay=_wtoi(sDay))<0)
		return -13;
	if((iHour=_wtoi(sHour))<0)
		return -14;
	if((iMinute=_wtoi(sMinute))<0)
		return -15;
	sysTime->wYear=iYear;
	sysTime->wMonth=iMonth;
	sysTime->wDay=iDay;
	sysTime->wHour=iHour;
	sysTime->wMinute=iMinute;
	sysTime->wSecond=0;
	sysTime->wMilliseconds=0;

	return 0;
}

///convert a systemtime to a YearMonthDayHourMinute string (ie "201112241423")
int getLongStrFromSysTime(SYSTEMTIME sysTime, TCHAR* sStr){
	int iRet=-1;
	wsprintf(sStr, L"000000000000");
	int iSize = wcslen(sStr);
	DWORD dwDbgLevel=regReadDbgLevel();
	if(iSize != 12){
		if(dwDbgLevel>4) nclog(L"getLongStrFromSysTime: str len not equal 12\n");
		return -1;	//string to short
	}
	TCHAR sTemp[12+1];
	wsprintf(sTemp, L"%04i%02i%02i%02i%02i", 
		sysTime.wYear,
		sysTime.wMonth,
		sysTime.wDay,
		sysTime.wHour, 
		sysTime.wMinute);
	wsprintf(sStr, L"%s", sTemp);
	if(dwDbgLevel>4) nclog(L"getLongStrFromSysTime: returning with '%s'\n", sStr);
	return 0; //no Error

}

TCHAR* getLongStrFromSysTime2(SYSTEMTIME sysTime){
		TCHAR* sTemp = new TCHAR[12+1];
		wsprintf(sTemp, L"%04i%02i%02i%02i%02i", 
			sysTime.wYear,
			sysTime.wMonth,
			sysTime.wDay,
			sysTime.wHour, 
			sysTime.wMinute);
		wsprintf(sTemp, L"%s", sTemp);
		return sTemp; //no Error
}

//normalize a SYSTEMTIME, ie, if hours is > 24
SYSTEMTIME fixSystemTime(SYSTEMTIME st){
	TCHAR szTemp[13]; wsprintf(szTemp, L"000000000000");
	DWORD dbgLevel=regReadDbgLevel();
	getLongStrFromSysTime(st, szTemp);
	if(dbgLevel>4) nclog(L"fixSystemTime: started with '%s'\n", szTemp);

	short shMin=st.wMinute;
	//minutes above 60? add to hours
	if(shMin>=60){
		st.wHour+=shMin/60;
		shMin=shMin%60;
	}
	short shHour = st.wHour;
	//hours above 24? add to days
	if(shHour>24)
	{
		st.wDay+=shHour/24;
		shHour=shHour%24;
	}

	SYSTEMTIME stReturn;
	memcpy(&stReturn, &st, sizeof(SYSTEMTIME));

	stReturn.wMinute=shMin;
	stReturn.wHour=shHour;

	getLongStrFromSysTime(stReturn, szTemp);
	if(dbgLevel>4) nclog(L"fixSystemTime: returning with '%s'\n", szTemp);
	return stReturn;
}

int regWriteDbgLevel(DWORD dwDbgLevel)
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to write
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=dwDbgLevel;
	if((iRes=RegWriteDword(L"dbglevel", &dwVal))==0)
		DEBUGMSG(1, (L"regWriteDbgLevel: OK. Debug Level is %i\n", dwVal));
	else
		DEBUGMSG(1, (L"regWriteDbgLevel: FAILED %i\n", iRes));
	return iRes;
}

DWORD regReadDbgLevel(){
	DWORD dbgLevel=0;
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegReadDword(L"dbglevel", &dwVal))==0){
		DEBUGMSG(1, (L"regReadDbgLevel: OK. dbglevel is %i\n", dwVal));
		dbgLevel=dwVal;
	}
	else{
		dwVal=1;
		DEBUGMSG(1, (L"regReadDbgLevel: FAILED %i\n", iRes));
		regWriteDbgLevel(0);
	}
	return dbgLevel;
}

int regReadKeys(){
	DWORD dwDbgLevel=regReadDbgLevel();

	int iRet = 0;
	//count number of subkeys
	wsprintf(g_subkey, _szRegKey);

	int iCount = regCountSubKeys();
	if(iCount==-1)
	{
		if(dwDbgLevel>4) nclog(L"regReadKeys: No sub keys found\n");
		return -1;
	}
	if(dwDbgLevel>4) nclog(L"regReadKeys: Found %i tasker sub keys\n", iCount);

	if(iCount>iMaxTasks)
		iCount=iMaxTasks;

	if(dwDbgLevel>4) nclog(L"regReadKeys: Allocating memory for %i tasks\n", iCount);
	for(int i=0; i<iMaxTasks; i++){
		memset(_szRegSubKeys[i],0,sizeof(TCHAR)*MAX_PATH);
	}
	iTaskCount=iCount;

	TCHAR szCurrentKey[MAX_PATH];
	for(int i=0; i<iCount; i++){
		int iRes=0;
		wsprintf(_szRegSubKeys[i], L"Task%i", i+1);

		wsprintf(_Tasks[i].szTaskKey, L"Task%i", i+1);
		//prepare subkey to read
		wsprintf(szCurrentKey, L"%s\\%s", _szRegKey, _szRegSubKeys[i]);
		OpenKey(szCurrentKey);
		if(dwDbgLevel>4) 
			nclog(L"regReadKeys: Processing task%i at '%s' ...\n", i, szCurrentKey);

		//now we can read the values in each task key
		TCHAR szTemp[MAX_PATH];
		DWORD dwTemp=0;
		if(RegReadDword(L"active", &dwTemp)==0){
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'active' entry is %i\n", dwTemp);
			_Tasks[i].iActive=dwTemp;
		}
		else
		{
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'active' entry, using 0 (inactive)\n");
			_Tasks[i].iActive=0;
		}

		OpenKey(szCurrentKey);
		if(RegReadStr(L"exe", szTemp)==0){
//			wsprintf(_ctasks[i]._task.szExeName, szTemp);
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'exe' entry is '%s'\n", szTemp);
			wsprintf(_Tasks[i].szExeName, szTemp);
		}
		else{
			_Tasks[i].iActive = 0x10 + iRes;
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'exe' entry!\n");
//			_ctasks[i]._task.iActive = 0x10 + iRes;
		}

		OpenKey(szCurrentKey);
		if(RegReadStr(L"args", szTemp)==0){
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'args' entry is '%s'\n", szTemp);
			wsprintf(_Tasks[i].szArgs, szTemp);
		}
		else{
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'args' entry!\n");
			wsprintf(_Tasks[i].szArgs, L"");
		}

		SYSTEMTIME st;
#if USE_NEXT_STARTSTOP
		//changes for v2.1, try the new reg entry
		if(RegReadStr(L"NextStart", szTemp)==0){
			iRes=getSTfromLongString(&st, szTemp);
			if(iRes==0)
				_Tasks[i].stStartTime=st;
			else
				_Tasks[i].iActive = 0x50 + iRes;
		}
#endif
//		else{
		//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info
		OpenKey(szCurrentKey);
			if(RegReadStr(L"start", szTemp)==0){
				if(dwDbgLevel>4) 
					nclog(L"\tregReadKeys: 'start' entry is '%s'\n", szTemp);
				iRes=getSTfromString(&st, szTemp);
				if(iRes==0){
					_Tasks[i].stStartTime=fixSystemTime(st);
					if(dwDbgLevel>4) 
						nclog(L"\tregReadKeys: task.stStartTime entry set\n");
				}
				else{
					if(dwDbgLevel>4) 
						nclog(L"\tregReadKeys: task.stStartTime could not be set, iRes=%i\n", iRes);
					_Tasks[i].iActive = 0x20 + iRes;
				}
			}
			else
			{
				if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'start' entry\n");
			}
//		}

#if USE_NEXT_STARTSTOP
		//changes for v2.1, try the new reg entry
		if(RegReadStr(L"NextStop", szTemp)==0){
			iRes=getSTfromLongString(&st, szTemp);
			if(iRes==0)
				_Tasks[i].stStopTime=st;
			else
				_Tasks[i].iActive = 0x60 + iRes;
		}
#endif
//		else{
		//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info
		OpenKey(szCurrentKey);
			if(RegReadStr(L"stop", szTemp)==0){
				if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'stop' entry is '%s'\n", szTemp);
				iRes=getSTfromString(&st, szTemp);
				if(iRes==0){
					if(dwDbgLevel>4) nclog(L"\tregReadKeys: task.stStopTime entry set\n");
					_Tasks[i].stStopTime=fixSystemTime(st);
				}
				else{
					_Tasks[i].iActive = 0x30 + iRes;
					if(dwDbgLevel>4) nclog(L"\tregReadKeys: task.stStopTime could not be set, iRes=%i\n", iRes);
				}
			}
			else
			{
				if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'stop' entry\n");
			}
//		}

		OpenKey(szCurrentKey);
		if(RegReadStr(L"interval", szTemp)==0){
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'interval' entry is '%s'\n", szTemp);
			iRes=getSTfromString(&st, szTemp);
			if(iRes==0){
				if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'interval' using %02i:%02i\n", st.wHour, st.wMinute);
				_Tasks[i].stDiffTime=st;
			}
			else{
				if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'interval' entry. Using Active=FALSE\n");
				_Tasks[i].iActive = 0x40 + iRes;
			}
		}
		else
		{
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'interval' entry\n");
		}
		if(_Tasks[i].iActive > 1)
			iRet += _Tasks[i].iActive;	// we had errors

		OpenKey(szCurrentKey);
		//read startOnAConly
		if(RegReadDword(L"startOnAConly", &dwTemp)==0){
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: 'startOnAConly' entry is %i\n", dwTemp);
			if(dwTemp==1)
				_Tasks[i].bStartOnAConly=TRUE;
			else
				_Tasks[i].bStartOnAConly=FALSE;
		}
		else
		{
			if(dwDbgLevel>4) nclog(L"\tregReadKeys: error in read 'startOnAConly' entry. Using FALSE\n");
			_Tasks[i].bStartOnAConly=FALSE;
		}
	}

//	_dwVersion = getVersion();

	return iRet;
}

int regDisableTask(int iTask){
	TCHAR szCurrentKey[MAX_PATH];
	//set inactive
	_Tasks[iTask].iActive=0;
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s\\%s", _szRegKey, _szRegSubKeys[iTask]);

	wsprintf(g_subkey, _szRegKey);

	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegWriteDword(L"active", &dwVal)) == 0)
		DEBUGMSG(1,(L"changed reg for task%i to inactive\n", iTask+1));
	else
		DEBUGMSG(1, (L"changing reg for task%i to inactive Failed: %i\n", iTask+1, iRes));
	return iRes;
}

int regEnableTask(int iTask){
	TCHAR szCurrentKey[MAX_PATH];
	//set inactive
	_Tasks[iTask].iActive=0;
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s\\%s", _szRegKey, _szRegSubKeys[iTask]);

	wsprintf(g_subkey, _szRegKey);

	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=1;
	if((iRes=RegWriteDword(L"active", &dwVal)) == 0)
		DEBUGMSG(1,(L"changed reg for task%i to inactive\n", iTask+1));
	else
		DEBUGMSG(1, (L"changing reg for task%i to inactive Failed: %i\n", iTask+1, iRes));
	return iRes;
}

int regSetStartTime(int iTask, SYSTEMTIME pStartTime){
	TCHAR szCurrentKey[MAX_PATH];

	//convert systemtime to HHmm
	TCHAR* szHM = new TCHAR[4+1];
	szHM = (TCHAR*)memset(szHM, 0, 4+1);
	wsprintf(szHM, L"0000");
	int iRet=0;
	if((iRet=getStrFromSysTime(pStartTime, szHM))!=0)
		return iRet;
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s\\%s", _szRegKey, _szRegSubKeys[iTask]);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);

	int iRes=0;
	DWORD dwVal=0;

//	if(_dwVersion<210L){
		//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info

		if((iRes=RegWriteStr(L"start", szHM)) == 0)
			DEBUGMSG(1,(L"changed start reg for task%i to '%s'\n", iTask+1, szHM));
		else
			DEBUGMSG(1, (L"changing start reg for task%i to '%s' Failed: %i\n", iTask+1, szHM, iRes));
//	}

	TCHAR sNextStart[13]; wsprintf(sNextStart, L"000000000000");
	if(getLongStrFromSysTime(pStartTime, sNextStart)==0){
		if((iRes=RegWriteStr(L"NextStart",sNextStart)) == 0){
			DEBUGMSG(1,(L"changed NextStart reg for task%i to '%s'\n", iTask+1, sNextStart));
			//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info
//			RegDelValue(L"start"); //delete obsolete value
			iRes=10;
		}
		else
			DEBUGMSG(1, (L"changing start reg for task%i to '%s' Failed: %i\n", iTask+1, sNextStart, iRes));
	}
	else{
		DEBUGMSG(1, (L"-getLongStrFromSysTime() failed\n"));
	}

	return iRes;
}

int regSetStopTime(int iTask, SYSTEMTIME pStopTime){
	TCHAR szCurrentKey[MAX_PATH];

	//convert systemtime to HHmm
	TCHAR* szHM = new TCHAR[4+1];
	szHM = (TCHAR*)memset(szHM, 0, 4+1);
	wsprintf(szHM, L"0000");
	int iRet=0;
	if((iRet=getStrFromSysTime(pStopTime, szHM))!=0)
		return iRet;
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s\\%s", _szRegKey, _szRegSubKeys[iTask]);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);

	int iRes=0;
	DWORD dwVal=0;

	//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info
//	if(_dwVersion<210L){
		if((iRes=RegWriteStr(L"stop", szHM)) == 0)
			DEBUGMSG(1,(L"changed stop reg for task%i to '%s'\n", iTask+1, szHM));
		else
			DEBUGMSG(1, (L"changing stop reg for task%i to '%s' Failed: %i\n", iTask+1, szHM, iRes));
//	}

	TCHAR sNextStop[13]; wsprintf(sNextStop, L"000000000000");
	if(getLongStrFromSysTime(pStopTime, sNextStop)==0){
		if((iRes=RegWriteStr(L"NextStop", sNextStop)) == 0){
			DEBUGMSG(1,(L"changed NextStop reg for task%i to '%s'\n", iTask+1, sNextStop));
				//change for v2.2: always only read start/stop values and use NextStart and NextStop only as info
//				RegDelValue(L"stop"); //delete obsolete value
			iRes=10;
		}
		else
			DEBUGMSG(1, (L"changing NextStop reg for task%i to '%s' Failed: %i\n", iTask+1, sNextStop, iRes));
	}
	else{
		DEBUGMSG(1, (L"-getLongStrFromSysTime() failed\n"));
	}

	return iRes;
}

BOOL getUpdateAll()
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegReadDword(L"UpdateAll", &dwVal))==0){
		if(dwVal==1){
			DEBUGMSG(1, (L"UpdateAll is TRUE\n"));
			return TRUE;
		}
		else{
			DEBUGMSG(1, (L"UpdateAll is FALSE\n"));
			return FALSE;
		}
	}
	else{
		DEBUGMSG(1, (L"UpdateAll ReadReg failed. Returning TRUE\n"));
		return TRUE;
	}
	setUpdateAll();
}

void setUpdateAll()
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=1;
	if((iRes=RegWriteDword(L"UpdateAll", &dwVal))==0)
		DEBUGMSG(1, (L"setUpdateAll: OK\n"));
	else
		DEBUGMSG(1, (L"setUpdateAll: FAILED %i\n", iRes));
}

void unsetUpdateAll()
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegWriteDword(L"UpdateAll", &dwVal))==0)
		DEBUGMSG(1, (L"setUpdateAll: OK\n"));
	else
		DEBUGMSG(1, (L"setUpdateAll: FAILED %i\n", iRes));
}

DWORD getVersion()
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegReadDword(L"Version", &dwVal))==0)
		DEBUGMSG(1, (L"getVersion: OK. Version is %i\n", dwVal));
	else{
		dwVal=200L;
		DEBUGMSG(1, (L"getVersion: FAILED %i\n", iRes));
	}
	return dwVal;
}

int writeMaxDelay(UINT uDelay)
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to write
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=uDelay;
	if((iRes=RegWriteDword(L"maxDelay", &dwVal))==0)
		DEBUGMSG(1, (L"writeMaxDelay: OK. Version is %i\n", dwVal));
	else
		DEBUGMSG(1, (L"writeMaxDelay: FAILED %i\n", iRes));
	return iRes;
}

/*
	read max allowed DeltaTime for ecognizing a delayed schedule
*/
int getMaxDelay(){
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to read
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=0;
	if((iRes=RegReadDword(L"maxDelay", &dwVal))==0)
		DEBUGMSG(1, (L"getMaxDelay: OK. maxDelay is %i\n", dwVal));
	else{
		dwVal=1;
		DEBUGMSG(1, (L"getMaxDelay: FAILED %i\n", iRes));
		writeMaxDelay(dwVal);
	}
	return dwVal;
}

int writeVersion(DWORD newVersion)
{
	TCHAR szCurrentKey[MAX_PATH];
	//prepare subkey to write
	wsprintf(szCurrentKey, L"%s", _szRegKey);
	wsprintf(g_subkey, _szRegKey);
	OpenKey(szCurrentKey);
	int iRes=0;
	DWORD dwVal=newVersion;
	if((iRes=RegWriteDword(L"Version", &dwVal))==0)
		DEBUGMSG(1, (L"writeVersion: OK. Version is %i\n", dwVal));
	else
		DEBUGMSG(1, (L"writeVersion: FAILED %i\n", iRes));
	return iRes;
}

void updateRegV2(){

}