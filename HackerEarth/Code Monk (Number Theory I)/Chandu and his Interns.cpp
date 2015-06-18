#include <iostream>
using namespace std;

int main() {
    long long T, bottleNum;
    
    cin >> T;
    
    while(T--){
    	cin >> bottleNum;
    	
    	int divisors = 1;
    	
    	for(long long i = 1; i < bottleNum && divisors < 4; i++){    		
    		if(i > 4 && bottleNum % 2 == 0) { // If it's divisible by 2, it has lots of divisors... so don't compute
    			divisors = 10; // I'm putting 10 just to force the condition to false
    		}
    		
    		if(bottleNum % i == 0){
    			divisors++;
    		}
    		
    		// TODO: Improve algorithm (doesn't work well on really long numbers)
    		
    	}
    	
    	if(divisors < 4) {
    		cout << "NO" << endl;
    	} else {
    		cout << "YES" << endl;
    	}
    }
    
    return 0;
}
