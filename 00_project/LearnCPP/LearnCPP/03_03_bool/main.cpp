#include<iostream>

static bool isEqual (int a, int b)
{
	return a == b;
}

int main()
{
	bool b1 = true;
	bool b2(false);
	bool b3{ true };

	std::cout << std::boolalpha; // Print bool values as true/false instead of 1/0
	std::cout << "b1: " << b1 << std::endl;
	std::cout << "b2: " << b2 << std::endl;
	std::cout << "b3: " << b3 << std::endl;

	std::cout << !b1 << std::endl; // NOT operator
	std::cout << (b2 && b3) << std::endl; // AND operator
	std::cout << (b2 || b3) << std::endl; // AND operator

	if (b2 && b3)
	{
		std::cout << "Both b2 and b3 are true" << std::endl;
	}
	else
	{
		std::cout << "At least one of b2 or b3 is false" << std::endl;
	}

	if (b2 || b3)
	{
		std::cout << "At least one of b2 or b3 is true" << std::endl;
	}
	else
	{
		std::cout << "Both b2 and b3 are false" << std::endl;
	}

	std::cout << "isEqual(3, 3): " << isEqual(3, 3) << std::endl;


	bool b;
	// 숫자 입력 시 0이 아닌 모든 값은 true로 간주됩니다. 나머지 문자열은 false
	std::cin >> b;
	std::cout << "You entered: " << b << std::endl;
	return 0;
}