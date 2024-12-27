#include <iostream>
#include <string>
#include <vector>
#include <algorithm>



int main()
{
    using namespace std;

    vector<char> gather = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
    string inputS;
    int T;
    while (true)
    {
        T = 0;
        getline(cin, inputS);

        if (inputS == "#")
        {
            break;
        }

        for (char c : inputS)
        {
            if (find(gather.begin(), gather.end(), c) != gather.end())
            {
                T++;
            }
        }

        cout << T << endl;
    }

    return 0;
}
