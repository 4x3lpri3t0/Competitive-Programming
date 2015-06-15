#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    int T, temp, min = 99;
    
    cin >> T;
    
    vector<int> sticks;
    
    while(T--){
        cin >> temp;
        sticks.push_back(temp);       
    }
    
    while(sticks.size() > 0){
        cout << sticks.size() << endl;
        
        for(auto x : sticks) {
            if(x < min) {
                min = x;
            }
        }
        
        vector<int>::iterator i = sticks.begin();
        while (i != sticks.end())
        {   
            *i -= min;
            
            if(*i <= 0) {
                i = sticks.erase(i); // You assign the current iterator first and then remove the element.
            } else {
                ++i;
            }
        }
        
        min = 99;
    }
    
    return 0;
}
