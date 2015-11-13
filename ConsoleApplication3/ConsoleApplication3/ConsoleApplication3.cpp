// ConsoleApplication3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
// file handling.cpp : Defines the entry point for the console application.
//
/*
ID: ashwin.7
PROG: ride
LANG: C++
*/
#include <iostream>
#include <fstream>
using namespace std;
#include <string>

int main()
{
	int conversion[26];
	for (int i = 0; i < 27; i++)
	{
		conversion[i] = i + 1;
	}
	char alphabet[26] = { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
	string a, b;
	cin >> a, b;
	int cometCounter = 1;
	for (int j = 0; j < a.length(); j++) {
		for (int i = 0; i < 27; i++)
		{
			if (a[j] == alphabet[i])
			{
				cometCounter = cometCounter * (i+1);
			}
		}
	}
	int group = 1;
	for (int j = 0; j < b.length(); j++) {
		for (int i = 0; i < 27; i++)
		{
			if (b[j] == alphabet[i])
			{
				group = group * (i+1);
			}
		}
	}
	if ((group % 47) == (cometCounter % 47)) {
		cout << "GO" << endl;
	}
	else
	{
		cout << "STAY" << endl;
	}

	return 0;
}

