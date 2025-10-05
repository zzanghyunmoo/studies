#include<iostream>
#include<cmath> // std::pow
#include<limits>
#include<cstdint>

int main()
{
	// 3.1 기본 자료형 소개
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
	}

	{
		int i1 = 1; // copy initialization
		int i2(2); // direct initialization
		int i3{ 3 }; // uniform initialization (C++11)

		std::cout << i1 << " " << i2 << " " << i3 << std::endl;
	}
	
	// 3.2 정수형
	{
		short s = 1;
		int i = 1;
		long l = 1;
		long ll = 1;

		std::cout << sizeof(s) << " " << sizeof(i) << " " << sizeof(l) << " " << sizeof(ll) << std::endl;
		std::cout << std::pow(2, sizeof(short) * 8 - 1) - 1 << " "  << std::numeric_limits<short>::max() << " " << std::numeric_limits<short>::min() << std::endl;
		std::cout << std::pow(2, sizeof(int) * 8 - 1) - 1 << " " << std::numeric_limits<int>::max() << " " << std::numeric_limits<int>::min() << std::endl;
		std::cout << std::pow(2, sizeof(long) * 8 - 1) - 1 << " " << std::numeric_limits<long>::max() << " " << std::numeric_limits<long>::min() << std::endl;
		std::cout << std::pow(2, sizeof(long long) * 8 - 1) - 1 << " " << std::numeric_limits<long long>::max() << " " << std::numeric_limits<long long>::min() << std::endl;

		s = std::numeric_limits<short>::max() + 1;
		std::cout << s << std::endl; // overflow

		s = std::numeric_limits<short>::min() - 1;
		std::cout << s << std::endl; // underflow

		unsigned int ui = -1;
		std::cout << ui << std::endl; // underflow

		std::cout << 22 / 5 << " " << 22 / (float)5 << std::endl; // integer division vs floating-point division
	}
	
	// 3.3 고정 너비 정수형
	{
		std::int8_t i8 = 1;
		std::int16_t i16 = 1;
		std::int32_t i32 = 1;
		std::int64_t i64 = 1;
		std::cout << sizeof(i8) << " " << sizeof(i16) << " " << sizeof(i32) << " " << sizeof(i64) << std::endl;

		std::int_fast16_t if16 = 1;
		std::int_least16_t il16 = 1;
		std::cout << sizeof(if16) << " " << sizeof(il16) << std::endl;
	}

	// 3.4 void
	{
		void* p = nullptr;
		int i = 42;
		p = &i;
		std::cout << *(static_cast<int*>(p)) << std::endl;
	}
	return 0;
}