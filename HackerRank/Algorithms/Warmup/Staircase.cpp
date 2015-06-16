#include <iostream>
#include <string>

using namespace std;

int main() {
    int staircaseMax;
    
    cin >> staircaseMax;
    
    for(int i = 1; i <= staircaseMax; i++) {
        int whitespaceNum = staircaseMax - i;
        string row = string(whitespaceNum, ' ') + string(i, '#');
        
        cout << row << endl;
    }
    
    return 0;
}
