#include <bits/stdc++.h>
using namespace std;

int Angry() {
    int totalStudents;
    int minStudents;
    int currentStudent;
    int assisting = 0;
    int numLines;
    
    cin >> numLines;
    
    for(int i = 0; i < numLines; i++) {
        cin >> totalStudents;
        cin >> minStudents;
        
        for(int j = 0; j < totalStudents; j++) {
            cin >> currentStudent;
            if(currentStudent <= 0) {
                assisting += 1;
            }
        }
        
        if(assisting >= minStudents) {
            cout << "NO\n";
        } else {
            cout << "YES\n";
        }
        
        assisting = 0;
    }
    
    return 0;
}