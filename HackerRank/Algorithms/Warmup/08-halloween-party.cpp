#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    long T, cuts, pieces;
    cin >> T;
    
    while(T--) {
        cin >> cuts;
        pieces = 0;
        
        if(cuts % 2 == 0) {
            pieces = (cuts / 2) * (cuts / 2);
        } else {
            pieces = ((cuts-1) / 2) * ((cuts-1) / 2 + 1);
        }
        
        cout << pieces << endl;
    }
    
    return 0;
}