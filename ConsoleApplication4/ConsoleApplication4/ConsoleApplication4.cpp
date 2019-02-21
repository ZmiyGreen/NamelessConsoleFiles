#include "pch.h"
#include <iostream>
#include <vector>
#include <algorithm>
#include <memory>

int main()
{
	/*std::vector<int> A(10);
	for (int i = 0; i < A.size(); i++)
		A[i] = i;
	std::for_each(A.begin(), A.end(), [](int &a) { a*=2; });
	for (const auto &i : A)
		std::cout << i << " ";
	std::cout << std::endl;*/
	std::vector<std::vector<int>> Mart = { {7,3,4,3}, {4,2,4,1}, {9,4,4,1} };
	for (auto i : Mart)
	{
		for (auto j : i)
			std::cout << j << " ";
		std::cout << std::endl;
	}

}
