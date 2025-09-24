#include<iostream>

int multiply(int x, int y)
{
	return x * y;
}

int main()
{
	std::cout << multiply(1, 2) << std::endl;
	std::cout << multiply(3, 4) << std::endl;
	std::cout << multiply(5, 6) << std::endl;
	return 0;
}