#include<iostream>

int main()
{
	char c1(65);
	char c2('A');

	std::cout << c1 << " " << c2 << std::endl;
	std::cout << (int)c1 << " " << (int)c2 << std::endl;
	std::cout << (char)65 << std::endl;

	std::cout << static_cast<char>(65) << std::endl;
	std::cout << static_cast<int>('A') << std::endl;

	char c3(66);
	std::cin >> c3;
	std::cout << c3 << " " << static_cast<int>(c3) << std::endl;
	
	std::cin >> c3;
	std::cout << c3 << " " << static_cast<int>(c3) << std::endl;
	return 0;
}