#include "pch.h"
#include <memory>
#include <array>
#include "Project.h"

int main()
{
	/*{
		std::shared_ptr<std::array<double, 100000000>> A(new std::array<double, 100000000>);
	}*/
	Search File("Input.txt");
	File.Show();
	File.Sort();
	File.Show();
	File.ShowTop(5);
}
