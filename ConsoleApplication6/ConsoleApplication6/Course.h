#include <iostream>
#include <string>

	class Course
	{
	private:
		double courseRating;
		std::string courseName;
	public:
		Course()
		{
			setName("");
			setRating(0);
		}
		Course(std::string Name, double Rating)
		{
			setName(Name);
			setRating(Rating);
		}
		virtual void setRating(double Value)
		{
			courseRating = Value;
		}
		virtual void setName(std::string Name)
		{
			courseName = Name;
		}
		virtual std::string getName()
		{
			return courseName;
		}
		virtual double getRating()
		{
			return courseRating;
		}
		virtual void Show()
		{
			std::cout << "Название курса: " << getName() << " Рейтинг курса: " << getRating() << std::endl;
		}
	};
	void Ru()
	{
		setlocale(LC_ALL, "rus");
	}
