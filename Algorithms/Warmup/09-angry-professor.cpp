#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <sstream>
using namespace std;

vector<int> parseInts(string str) {
    stringstream ss(str);
    vector<int> result(0);
    string token;

    while(std::getline(ss, token, ',')) {
        result.push_back(stoi(token));
    }

    return result;
}

int main() {
    string cancelled;
    int totalStudents;
    int minStudents;
    int currentStudent;
    int assisting = 0;
    vector<int> students;
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