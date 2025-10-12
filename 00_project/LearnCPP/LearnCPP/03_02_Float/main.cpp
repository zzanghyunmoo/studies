#include<iostream>
#include<iomanip>
#include<limits>


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
	
	std::cout << "Max float: " << std::numeric_limits<float>::max() << "Min float: " << std::numeric_limits<float>::min() << std::endl;
	std::cout << "Max double: " << std::numeric_limits<double>::max() << "Min double: " << std::numeric_limits<double>::min() << std::endl;
	std::cout << "Max long double: " << std::numeric_limits<long double>::max() << "Min long double: " << std::numeric_limits<long double>::min() << std::endl;
	
	std::cout << 3.14 << " " << 31.4e-1 << " " << 314e-2 << std::endl;
	
	std::cout << std::setprecision(20); // Set precision for floating-point output
	std::cout << 1.0 / 3.0 << std::endl; // Outputs approximately 0.33333333333333331483
	
	double d2(0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1);
	std::cout << d2 << std::endl; // Outputs 1.0000000000000000000
	return 0;
}