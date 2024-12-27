#include <iostream>
#include <unordered_map>
#include <string>
int main()
{
	std::unordered_map<std::string, std::string> classRoom;
	int N;
	std::cin >> N;
	classRoom["Algorithm"] = "204";
	classRoom["DataAnalysis"] = "207";
	classRoom["ArtificialIntelligence"] = "302";
	classRoom["CyberSecurity"] = "B101";
	classRoom["Network"] = "303";
	classRoom["Startup"] = "501";
	classRoom["TestStrategy"] = "105";
	
	for (int i = 0; i < N; i++)
	{
		std::string keyS;
		
		std::cin >> keyS;

		std::string vluS = classRoom[keyS];
		std::cout << vluS << std::endl;

		
	}
	
	return 0;
}