// ConsoleApplication2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <iostream>
using namespace std;


int main()
{
	cout << "Enter the number that you which to convert from decimal to binary" << endl;
	double binary[7];
	double input(0);
	cin >> input;
	double highest;
	for (int i = 0; i < 8; i++)
	{
		double temp = pow(2, i);
		if (input % temp == 1)
		{
			binary[i] = 1;
			input = input - pow(2, i);
		}
		else {
			binary[i] = 0;
		}
	}
	return 0;
}
