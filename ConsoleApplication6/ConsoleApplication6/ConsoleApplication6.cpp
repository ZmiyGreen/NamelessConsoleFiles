#include "pch.h"
#include "Course.h"
#include <array>
#include <functional>
#include <algorithm>

class BoostCourse : public Course
{
public:
	BoostCourse(std::string Name, double Raiting)
	{
		setName(Name);
		setRating(Raiting);
	}
	void setName(std::string Name) override
	{
		if (Name.length() <= 20)
			Course::setName(Name);
		else
			Course::setName(Name.substr(0, 20));
	}
	void setRating(double Rating) override
	{
		if (Rating >= 0 && Rating <= 5)
			Course::setRating(Rating);
		else
			Course::setRating(0);
	}
public:
	bool operator <(BoostCourse Other)
	{
		return getRating() < Other.getRating();
	}
};

int main()
{
	std::function f = [](int a) {std::cout << a; };
	Ru();
	std::array<BoostCourse, 5> Courses
	{
		    BoostCourse("Матан", 2.4),
			BoostCourse("Ангем", 1.4),
			BoostCourse("Линал", 3.9),
			BoostCourse("Информатика", 1.9),
			BoostCourse("Базы данных", 3.2)
	};
	std::sort(Courses.begin(), Courses.end());
	std::reverse(Courses.begin(), Courses.end());
	for (auto& i : Courses)
		i.Show();
}

