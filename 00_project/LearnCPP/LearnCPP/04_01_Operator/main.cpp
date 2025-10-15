#include<iostream>

int main()
{
	// Operator precedence and associativity
	int x = 4 + 2 * 3;
	int y = (4 + 2) * 3;
	std::cout << x << " " << y << std::endl; 

	x = 3 * 4 / 3;
	y = 3 * (4 / 3);
	std::cout << x << " " << y << std::endl;

	// Arithmetic operators
	int x1 = 1;
	int y1 = 5 + -x1; 
	std::cout << x1 << " " << y1 << std::endl;

	std::cout << (x1 + y1) << std::endl; // Addition
	std::cout << (x1 - y1) << std::endl; // Subtraction
	std::cout << (x1 * y1) << std::endl; // Multiplication
	std::cout << (x1 / static_cast<double>(y1)) << std::endl; // Division
	std::cout << (x1 % y1) << std::endl; // Modulus

	x1 += 1; // x = x + 1
	std::cout << x1 << std::endl;
	x1 -= 1;
	std::cout << x1 << std::endl;
	x1 *= 2;
	std::cout << x1 << std::endl;
	x1 /= 2;
	std::cout << x1 << std::endl;

	// increment and decrement operators
	int x2 = 5;
	int y2 = ++x2; // pre-increment
	std::cout << x2 << " " << y2 << std::endl;

	x2 = 5;
	y2 = x2++; // post-increment
	std::cout << x2 << " " << y2 << std::endl;

	// sizeof, commma, conditional operators
	std::cout << sizeof(int) << std::endl;
	std::cout << sizeof(x2) << std::endl;
	std::cout << sizeof x2 << std::endl;

	x2 = 3;
	y2 = 10;
	// comma operator 
	// 1. 앞에 있는 ++x2 먼저 실행
	// 2. 뒤에 있는 ++y2 실행
	// 3. z2에 y2 대입
	int z2 = (++x2, ++y2); 
	std::cout << x2 << " " << y2 << " " << z2 << std::endl;

	// 요건 comma operator 아님. 단순 구분자
	// 1. = 연산자 우선순위에 의해  z2 = x2 실행
	// 2. y2 실행 (의미는 없음)
	z2 = x2, y2;
	std::cout << x2 << " " << y2 << " " << z2 << std::endl;

	// conditional operator
	int x3 = 3;
	int y3 = 5;
	int z3 = (x3 > y3) ? x3 : y3; // if-else
	std::cout << z3 << std::endl;
	return 0;
}