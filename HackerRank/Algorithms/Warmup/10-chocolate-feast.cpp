#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int t,n,c,m;
    cin>>t;
    while(t--){
        cin>>n>>c>>m;
        int answer = 0;
        int wrappers = floor(n / c);
        answer = wrappers;
        
        while(wrappers >= m) {
            int remainder = wrappers % m;
            int newChocolates = floor(wrappers / m);
            wrappers = remainder + newChocolates;
            
            answer += newChocolates;
        }
        
        cout<<answer<<endl;
    }
    return 0;
}
