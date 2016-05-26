#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    string word;
    string substringToReplace;
    string reversedSubstring;
    int T;

    int posA;
    int posB;
    char charAtA;
    char charAtB;
    
    cin >> word;
    cin >> T;
    
    while (T--) {
        cin >> posA;
        cin >> posB;
        
        int len = (posB - posA) + 1;

        substringToReplace = word.substr(posA, len);
           
        reverse(substringToReplace.begin(), substringToReplace.end());

        word.replace(posA, len, substringToReplace);

        cout << word << endl;
    }
    
    return 0;
}
