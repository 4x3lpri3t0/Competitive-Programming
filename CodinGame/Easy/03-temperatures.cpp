#include <iostream>
#include <sstream>

using namespace std;

int main()
{
    int N; // the number of temperatures to analyse
    cin >> N; cin.ignore();
    string TEMPS; // the N temperatures expressed as integers ranging from -273 to 5526
    getline(cin, TEMPS);

    stringstream stream(TEMPS);
    int n, nAbs;
    const int MAX_TEMP = 5526;
    int closestTempAbs = MAX_TEMP;
    int closestTemp;
    
    while(stream >> n){
        nAbs = abs(n);
        
        if(nAbs == closestTempAbs && n < 0) {
            continue; // If two numbers are equally close to zero, positive integer has to be considered closest to zero
        } else if (nAbs <= closestTempAbs) {
            closestTempAbs = nAbs;
            closestTemp = n;
        }
    }

    if(n == 0) { // If no temperature is provided; display 0
        cout << 0 << endl;
    } else {
        cout << closestTemp << endl;
    }
}