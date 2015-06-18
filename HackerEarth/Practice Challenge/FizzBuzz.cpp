#include <iostream>

using namespace std;

int main()
{
	int T, limit;
	
	cin >> T;
	
	while(T--) {
		cin >> limit;
		
		for(int i = 1; i <= limit; i++){
			string result = "";
			
			if(i % 3 == 0 || i % 5 == 0) {
				if(i % 3 == 0) {
					result = "Fizz";
				}
				if(i % 5 == 0) {
					result += "Buzz";
				}
				
				cout << result << endl;
			} else {
				cout << i << endl;
			}
		}
	}

    return 0;
}