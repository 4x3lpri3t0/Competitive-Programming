#include <iostream>
#include <set>

using namespace std;

int main() {
    int T, n, a, b;
    
    cin >> T;
    
    while(T--) {
        cin >> n >> a >> b;
        
        set<int> lastStonesSet;
        set<int>::iterator it;
        
        for(int i = 0; i < n; i++) {
            // Set
            lastStonesSet.insert((a * i) + (b * (n - 1 - i)));
        }
        
        for (it = lastStonesSet.begin(); it != lastStonesSet.end(); ++it) {
            cout << *it << ' ';
        }

        cout << '\n';
    }
    
    return 0;
}