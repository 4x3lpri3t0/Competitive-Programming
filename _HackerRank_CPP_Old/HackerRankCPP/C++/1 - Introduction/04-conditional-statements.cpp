#include <iostream>
#include <string>
using namespace std;

void start(){
    string a[] = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    
    int check;
    
    cin >> check;
    
    if(check > 9){
        cout << "Greater than 9";
    }else{
        cout << a[check];
    }
}

int main() {
    start();
    return 0;
}