#include <iostream>
#include <string>

using namespace std;

int main() {
    int n;
    
    // ORGANIZE INPUT
    cin >> n;
    int map[n][n];
    for(int i = 0; i < n; i++) {
        string strLine;
        int j = 0;
        cin >> strLine;
        
        for(char& c : strLine) {
            // Convert char to int
            map[i][j++] = c - '0';
        }
    }
    
    // ALGORITHM
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
            int current = map[i][j];
            
            if(j > 0 && i > 0 && j < n-1 && i < n-1 && // Don't calculate the border values, but print them
            current > map[i-1][j] &&
            current > map[i+1][j] &&
            current > map[i][j-1] &&
            current > map[i][j+1]) {
                cout << "X";
            } else {
                cout << current;
            }
        }
        cout << "\n";
    }
    
    return 0;
}