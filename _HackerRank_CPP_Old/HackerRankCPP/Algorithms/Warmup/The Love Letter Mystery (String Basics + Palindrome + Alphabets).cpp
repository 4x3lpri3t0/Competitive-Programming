#include <iostream>
#include <string>

using namespace std;

void PrintPalindromeOperations(string str) {
    int ops = 0, i = 0;
    
    while(i + 1 <= str.size() / 2) {
        char left = str[i];
        char right = str[str.size() - 1 - i];
        
        if(left == right) {
            i++;
        } else {
            if((int)left > (int)right) {
                str[i] = --left;
            } else {
                str[str.size() - 1 - i] = --right;
            }

            ops++;
        }
    }
    
    cout << ops << endl;
}

int main() {
    int T;
    string str;
    cin >> T;
    
    while(T--){
        cin >> str;
        PrintPalindromeOperations(str);
    }
    
    return 0;
}