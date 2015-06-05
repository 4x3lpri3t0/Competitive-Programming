#include <iostream>
#include <string>
using namespace std;

int main() {
    string firstStr = "";
    string secondStr = "";
    
    cin >> firstStr;
    cin >> secondStr;
    
    int firstLength = firstStr.size();
    int secondLength = secondStr.size();
    
    cout << firstLength << " " << secondLength << endl;
    
    cout << firstStr + secondStr << endl;
    
    string firstMix = secondStr[0] + firstStr.substr(1);
    string secondMix = firstStr[0] + secondStr.substr(1);
    
    cout << firstMix << " " << secondMix;
    
    return 0;
}