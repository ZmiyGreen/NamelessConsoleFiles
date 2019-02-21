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
	double SumResult = 0;
public:
	Person(std::string N, std::initializer_list<double> L) : Name(N)
	{
		int index = 0;
		for (double i : L)
			Results[index++] = i;
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
	bool operator<(const Person& Other)
	{
		return SumResult < Other.SumResult;
	}
};
class Sport
{
private:
	std::vector<Person> Data;
public:
	Sport()
	{ }
	void Add(std::string N, std::initializer_list<double> L)
	{
		Data.push_back(Person(N, L));
	}
	void Add(Person P)
	{
		Data.push_back(P);
	}
	void Print()
	{
		for (auto i : Data)
			i.Print();
	}
	void Sort()
	{
		std::sort(Data.begin(), Data.end());
		std::reverse(Data.begin(), Data.end());
	}
};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	Person P1("Иванов1", { 7,4,2,0,4 });
	Person P2("Иванов2", { 9,2,4,0.5,4.2 });
	Person P3("Иванов3", { 7,2,3,1,8 });
	Person P4("Иванов4", { 4,0.7,2.3,0.2,8 });
	Person P5("Иванов5", { 2,4.2,3,2,8.9 });
	/*std::vector<Person> V = { P1, P2, P3, P4, P5 };
	for (auto i : V)
		i.Print();
	std::cout << std::endl;
	std::sort(V.begin(), V.end());
	std::reverse(V.begin(), V.end());
	for (auto i : V)
		i.Print();*/
	Sport SportList;
	SportList.Add(P1);
	SportList.Add(P2);
	SportList.Add(P3);
	SportList.Add(P4);
	SportList.Add(P5);
	SportList.Print();
	std::cout << std::endl;
	SportList.Sort();
	SportList.Print();
}