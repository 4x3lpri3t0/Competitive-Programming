#include <iostream>

using namespace std;

int main() {
    int V, n;
    
    cin >> V >> n;
    
    for(int i = 0; i < n; i++) {
        int current;
        cin >> current;
        
        if(V == current) {
            cout << i;
        }
    }
    
    return 0;
}
