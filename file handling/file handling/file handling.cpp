// file handling.cpp : Defines the entry point for the console application.
//
/*
ID: ashwin.7
PROG: test
LANG: C++
*/
#include <iostream>
#include <fstream>
using namespace std;
#include <string>

int main()
{
	ofstream fout("test.out");
	ifstream fin("test.in");
	int a(0), b(0);
	fin >> a >> b;
	fout << (a + b) << endl;
    return 0;
}

