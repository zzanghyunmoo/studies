#include<iostream>

int main()
{
	int i = 42;
	char c = 'a';
	bool b = true;
	double d = 3.14;

	auto a = 3.14f; // float

	std::cout << sizeof(i) << " " << (uintptr_t)static_cast<void*>(&i) << std::endl;
	std::cout << sizeof(c) << " " << (uintptr_t)static_cast<void*>(&c) << std::endl;
	std::cout << sizeof(b) << " " << (uintptr_t)static_cast<void*>(&b) << std::endl;
	std::cout << sizeof(d) << " " << (uintptr_t)static_cast<void*>(&d) << std::endl;
	std::cout << sizeof(a) << " " << (uintptr_t)static_cast<void*>(&a) << std::endl;

	int i1 = 1; // copy initialization
	int i2(2); // direct initialization
	int i3{ 3 }; // uniform initialization (C++11)

	std::cout << i1 << " " << i2 << " " << i3 << std::endl;
	return 0;
}