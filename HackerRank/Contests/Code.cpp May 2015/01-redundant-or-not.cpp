#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    vector<int> myvector;
    vector<int>::iterator it;
    int num;
    int T;
    cin >> T;
    
    while (T--) {
        cin >> num;
        
        it = find (myvector.begin(), myvector.end(), num);
        if (it != myvector.end()) {
            cout << "REDUNDANT\n";
        }
        else {
            myvector.push_back(num);
            cout << "ADDED\n";
        }
    }
    
    return 0;
}
