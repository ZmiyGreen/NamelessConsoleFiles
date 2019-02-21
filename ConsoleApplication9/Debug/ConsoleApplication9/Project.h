#include <iostream>
#include <vector>
#include <fstream>
#include <map>
#include <string>

class Search
{
private:
	std::map <std::string, int> Counter;
	std::vector<std::pair<std::string, int>> Results;
public:
	Search(std::string_view Path)
	{
		std::string Text;
		std::fstream Stream(Path.data());
		while (Stream >> Text)
			++Counter[Text];
		Stream.close();
		Results = { Counter.cbegin(), Counter.cend() };
	}
	void Show()
	{
		for (const auto& i : Results)
			std::cout << i.first << " " << i.second << std::endl;
		std::cout << std::endl;
	}
	void ShowTop(int Top)
	{
		for (int i = 0; i < Top; i++)
			std::cout << Results[i].first << " " << Results[i].second << std::endl;
	}
	void Sort()
	{
		std::sort(Results.begin(), Results.end(), [](const auto& i, const auto& j) {return i.second > j.second; });
	}
	/*void Sort()
	{
		std::sort(Results.rbegin(), Results.rend(), [](const std::pair<std::string, int>& a, const std::pair<std::string, int> b) {return a.second < b.second; });
	}*/
};