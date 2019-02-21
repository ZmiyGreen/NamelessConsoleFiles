#include "pch.h"
#include <iostream>

void Num(int &A, int &B)
{
	A *= B;
	B += A;
}
int main()
{

	int ALen = 5;
	int *A = new int[ALen];
	for (int i = 0; i < ALen; i++)
		A[i] = i * 2;
	for (int i = 0; i < ALen; i++)
		std::cout << A[i] << " ";
	delete[] A;
	std::cout << std::endl;
	int a = 0;
	int b = 0;
	std::cin >> a >> b;
	std::cout << a << " " << b << std::endl;
	Num(a, b);
	std::cout << a << " " << b << std::endl;
}
