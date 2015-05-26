#include <iostream>
#include <cstdio>
#include <string>
#include <array>
using namespace std;

int main() {
    string intsAsWords[] = {"zero","one","two","three","four","five","six","seven","eight","nine"};
    int inputs[2];
    
    cin >> inputs[0];
    cin >> inputs[1];
    
    for(int i = inputs[0]; i <= inputs[1]; i++){
        if(i <= 9) {
            cout << intsAsWords[i] << endl;
        } else if(i % 2 == 0) {
            cout << "even" << endl;
        } else {
            cout << "odd" << endl;
        }
    }
    
    return 0;
}