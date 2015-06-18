#include <iostream>

using namespace std;

int main()
{
    int T, numA, numB;
    
    cin >> T;
    
    while(T--){
    	cin >> numA >> numB;
    	
    	cout << numA + numB << endl;
    }
    
    return 0;
}