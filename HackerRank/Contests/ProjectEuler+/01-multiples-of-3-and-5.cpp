#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int T, max, sum;
    cin >> T;
    
    while(T--){
        cin >> max;
        sum = 0;
        
        for(int i = 3; i < max; i++){
            if(i % 3 == 0 || i % 5 == 0){
                sum += i;
            }
        }
        
        cout << sum << endl;
    }
    
    return 0;
}
