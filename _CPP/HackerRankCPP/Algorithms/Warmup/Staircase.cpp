#include <bits/stdc++.h>
using namespace std;

int Staircase() {
    int staircaseMax;
    
    cin >> staircaseMax;
    
    for(int i = 1; i <= staircaseMax; i++) {
        int whitespaceNum = staircaseMax - i;
        string row = string(whitespaceNum, ' ') + string(i, '#');
        
        cout << row << endl;
    }
    
    return 0;
}
