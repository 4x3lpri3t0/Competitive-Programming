#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    long T, pieces;
    double cuts; // IMPORTANT! cuts has to be double, so we get decimals when we divide / 2
    cin >> T;
    
    while(T--) {
        cin >> cuts;
        
        long firstHalf = floor(cuts / 2); // round down
        long secondHalf = ceil(cuts / 2); // round up

        pieces = firstHalf * secondHalf;
        
        cout << pieces << endl;
    }
    
    return 0;
}
