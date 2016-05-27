#include <bits/stdc++.h>
using namespace std;

int StringTransformations() {
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
