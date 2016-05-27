#include <bits/stdc++.h>
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

int StringStream() {
    string str;
    cin >> str;
    vector<int> integers = parseInts(str);
    for(int i = 0; i < integers.size(); i++) {
        cout << integers[i] << "\n";
    }
    
    return 0;
}