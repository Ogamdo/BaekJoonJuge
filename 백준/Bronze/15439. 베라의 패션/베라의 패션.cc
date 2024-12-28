#include <iostream>

int main()
{
	int N, r;
	r = 1;
	std::cin >> N;
	if (N > 1)
	{
		r = N * (N - 1);
	}
	else if(N==1)
	{
		r = 0;
	}
	std::cout << r;
		
}