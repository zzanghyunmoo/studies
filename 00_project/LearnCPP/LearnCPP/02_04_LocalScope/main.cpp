#include<iostream>

int main() 
{
	int x(0);

	{
		int y(1);
		std::cout << "x: " << x << ", y: " << y << std::endl;
	}
	//std::cout << "x: " << x << ", y: " << y << std::endl;
	std::cout << "x: " << x << std::endl;

	int y(2);
	std::cout << "y: " << y << " " << &y << std::endl;

	{
		std::cout << "y: " << y << " " << &y << std::endl;

		int y(3);
		std::cout << "y: " << y << " " << &y << std::endl;
	}
	return 0;
}