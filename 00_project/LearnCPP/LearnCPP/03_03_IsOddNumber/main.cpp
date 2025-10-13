#include<iostream>

// Function to check if number number is odd ex: 1, 3, 5, 7, 9...
static bool isOddNumber(int number)
{
	return number % 2 != 0;
}

int main()
{
	int number;
	std::cout << "Enter an integer: ";
	std::cin >> number;

	if (std::cin.fail()) // Check if the input operation failed
	{
		std::cerr << "Invalid input. Please enter number valid integer." << std::endl;
		return 1; // Return with an error code
	}

	std::cout << std::boolalpha; // Print bool values as true/false instead of 1/0
	if (isOddNumber(number))
	{
		std::cout << number << " is an odd number." << std::endl;
	}
	else
	{
		std::cout << number << " is not an odd number." << std::endl;
	}
	return 0;
}