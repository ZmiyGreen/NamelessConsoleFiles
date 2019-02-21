#include "pch.h"
#include <iostream>
#include <array>
#include <vector>
#include <string>
#include "windows.h"


class Person
{
private:
	std::string Name;
	std::array<double, 5> Results;
	double SumResult;
public:
	Person(std::string N, std::initializer_list<double> L) : Name(N)
	{
		int index = 0;
		for (double i : L)
		{
			Results[index++] = i;
			std::cout << Results[index - 1] << " ";
		}
		int imin = 0;
		int imax = 0;
		for (int i = 1; i < Results.size(); i++)
		{
			if (Results[i] > Results[imax])
				imax = i;
			if (Results[i] < Results[imin])
				imin = i;
		}
		for (int i = 0; i < Results.size(); i++)
			if (i != imax && i != imin)
				SumResult += Results[i];
	}
	void Print()
	{
		std::cout << "Имя: " << Name << " Суммарный результат: " << SumResult << " Результаты попыток: ";
		for (auto i : Results)
			std::cout << i << " ";
		std::cout << std::endl;
	}
};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	Person P("Иванов", { 7,4,2,0,4 });
	P.Print();
	std::cout << "Привет мир!\n";
}