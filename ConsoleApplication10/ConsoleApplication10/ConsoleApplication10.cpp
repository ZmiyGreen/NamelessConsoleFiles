#include "pch.h"
#include <iostream>
#include <vector>
#include <map>
#include <string>
#include <algorithm>

int main()
{
	setlocale(LC_ALL, "rus");
	std::map<std::string, double> Dicr
	{
		{"Москва", 5.8},
	    {"Питер", 4.4},
	    {"Тверь", 9.3},
	    {"можайск", 1.3}
	};
	std::vector<std::pair<std::string, double>> V{ Dicr.cbegin(), Dicr.cend() };
	std::sort(V.begin(), V.end(), [](const auto& a, const auto& b) {return b.second > a.second; });
	for (const auto& i : V)
		std::cout << i.first << " " << i.second << std::endl;
}
