#include <bits/stdc++.h>
using namespace std;

int TreeHeight(int n) {
    int height = 1;
    
    for(int i = 0; i < n; i++) {
        if(i % 2 == 0){
            height *= 2;
        } else {
            height += 1;
        }
    } 
    
    return height;
}

void UtopianTree() {
    int T;
    cin >> T;
    while (T--) {
        int n;
        cin >> n;
        cout << TreeHeight(n) << endl;
    }
}