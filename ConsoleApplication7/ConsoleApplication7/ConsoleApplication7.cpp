#include "pch.h"
#include <iostream>
#include <array>

class Numpers
{
private:
	int x;
	int y;
	int z;
public:
	explicit Numpers(int x1, int x2, int x3)
	{
		x = x1;
		y = x2;
		z = x3;
	}
	void Show()
	{
		std::cout << "Числа: " << x << " " << y << " " << z << std::endl;
	}
};

template<typename T, size_t S> 
void Print(const std::array<T, S> &A)
{
	for (const auto &i : A)
		std::cout << i << " ";
	std::cout << std::endl;
}

int main()
{
	//setlocale(LC_ALL, "rus");
	//Numpers A { 8, 5, 3 };
	//A.Show();
	std::array A { 7,4,5,6,4 };
	for (const auto &i : A)
		std::cout << i * 2 << std::endl;
	Print<int, A.size()>(A);
	int B[]{ 9,5,5,3,4 };
	for (auto i : B)
		std::cout << i << " ";
}
