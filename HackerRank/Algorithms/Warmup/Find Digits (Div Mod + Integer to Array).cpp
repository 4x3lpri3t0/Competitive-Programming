#include <iostream>
#include <list>

using namespace std;

int main() {
    int T, originalNumber, tempNum, divisors;
    list<int> digits;
    
    cin >> T;
    
    while(T--){
        digits.clear();
        divisors = 0;
        
        cin >> originalNumber;
        tempNum = originalNumber;
        
        while(tempNum != 0) {
            // Div Mod
            int remainder = tempNum % 10;
            digits.push_back(remainder); // Integer to List
            tempNum -= remainder;
            tempNum /= 10;
        } 

        list<int>::iterator it;
        for (it = digits.begin(); it != digits.end(); ++it) {
            if(*it != 0 && originalNumber % *it == 0) {
                divisors++;
            }
        }
        
        cout << divisors << endl;
    }
    
    return 0;
}