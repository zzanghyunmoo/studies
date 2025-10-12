#include<iostream>

int main()
{
	float f1 = 3.14f; // 'f' suffix indicates a float literal
	double d1 = 3.14; // Default is double
	long double ld1 = 3.14L; // 'L' suffix indicates a long double literal
	std::cout << "Size of float: " << sizeof(f1) << " bytes" << std::endl;
	std::cout << "Size of double: " << sizeof(d1) << " bytes" << std::endl;
	std::cout << "Size of long double: " << sizeof(ld1) << " bytes" << std::endl;
	std::cout << "Value of float: " << f1 << std::endl;
	std::cout << "Value of double: " << d1 << std::endl;
	std::cout << "Value of long double: " << ld1 << std::endl;
	return 0;
}