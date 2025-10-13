#include <iostream>

int main()
{
	int num1 = 012;
	int num2 = 0xA;
	int num3 = 10;
	int num4 = 0b1010; // C++14 feature
	std::cout << std::oct << num1 << " " << num2 << " " << num3 << " " << num4 << std::endl;
	std::cout << std::hex << num1 << " " << num2 << " " << num3 << " " << num4 << std::endl;
	std::cout << std::dec << num1 << " " << num2 << " " << num3 << " " << num4 << std::endl;
	
	const int PRICE_PER_ITEM = 10; // symbolic constant
	int num_items = 5;
	int total_price = PRICE_PER_ITEM * num_items;
	std::cout << "Total price: " << total_price << std::endl;
	return 0;
}