#include "pch.h"
#include <iostream>
#include <string>
#include <windows.h>
#include <vector>
#include <algorithm>

class Account
{
protected:
	unsigned int accountNumber;
	std::string firstName;
	std::string lastName;
	double balance;
public:
	Account(unsigned int account, std::string first, std::string last, double b) : accountNumber(account), firstName(first), lastName(last), balance(b) {};
	virtual void Print()
	{
		std::cout << "ID: " << accountNumber << " Имя: " << firstName << " Фамилия: " << lastName << " Баланс: " << balance << std::endl;
	}
	virtual bool operator <(const Account& Other)
	{
		return balance < Other.balance;
	}
};

class ModAccount : Account
{
protected:
	std::vector<int> BornDate; // Дата рождения День.Месяц.Год
public:
	 ModAccount(unsigned int account, std::string first, std::string last, double b, std::vector<int> Date) : Account(account, first, last, b), BornDate(Date) {};
	void Print() override
	{
		std::cout << "ID: " << accountNumber << " Имя: " << firstName << " Фамилия: " << lastName << " Дата рождения: " <<BornDate[0] << "." << BornDate[1] <<"." << BornDate[2] << " Баланс: " << balance << std::endl;
	}
	bool operator <(const ModAccount& Other)
	{
		return balance < Other.balance;
	}
};

void Ru()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
}

void Print(std::vector<ModAccount>& V)
{
	for (auto i : V)
		i.Print();
	std::cout << std::endl;
}

int main()
{
	Ru();
	/*std::vector<Account> Clients
	{
		{ 0, "Иван", "Иванов", 400.8 },
		{ 1, "Петр", "Петров", 490.8 },
		{ 2, "Сергей", "Сергеев", 300.8 },
		{ 3, "Александр", "Александров", 100.8 },
		{ 4, "Алексей", "Алексеев", 270.8 }
	};*/
	std::vector<ModAccount> Clients
	{
		{ 0, "Иван", "Иванов", 400.8, {20, 2, 2001} },
		{ 1, "Петр", "Петров", 490.8, {20, 2, 2001} },
		{ 2, "Сергей", "Сергеев", 300.8, {20, 2, 2001} },
		{ 3, "Александр", "Александров", 100.8, {20, 2, 2001} },
		{ 4, "Алексей", "Алексеев", 270.8, {20, 2, 2001} }
	};
	Print(Clients);
	std::sort(Clients.begin(), Clients.end());
	std::reverse(Clients.begin(), Clients.end());
	Print(Clients);
}

