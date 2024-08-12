#include <iostream>
#include <string>

using namespace std;

char ar[26];

int main()
{
	string s;
	cin >> s;
	for (auto it : s)
	{
		ar[(it -'a')]++;
	}
	for (int i=0 ;i < 26; i++)
	{
		cout << (int)ar[i] << " ";
	}
}