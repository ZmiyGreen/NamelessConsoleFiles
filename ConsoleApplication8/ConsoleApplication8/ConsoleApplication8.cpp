#include "pch.h"
#include <iostream>
#include <vector>
#include <algorithm>

template<typename T>
void Print(const std::vector<T> &V)
{
	for (auto &i : V)
		std::cout << i << " ";
	std::cout << std::endl;
}
void BSort(std::vector<int> &V)
{
	for (int i = 0; i < V.size() - 1; i++)
		for (int j = i + 1; j < V.size(); j++)
			if (V[i] < V[j])
				std::swap(V[i], V[j]);
}


int main()
{
	std::vector<int> V { 8,4,2,4,2, 9, 2,7,3,7 };
	//std::sort(V.rbegin() , V.rend());
	BSort(V);
	Print(V);
}
