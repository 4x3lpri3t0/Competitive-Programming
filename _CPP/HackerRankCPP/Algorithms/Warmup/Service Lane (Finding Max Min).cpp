#include <bits/stdc++.h>
using namespace std;

int ServiceLane() {
    int freewayLength, numberOfTestCases, tempInput, start, end;
    int largestVehicle = 0;
    int minSegLength = 9;
    vector<int> segments(0);

    cin >> freewayLength >> numberOfTestCases;
    
    for(int i = 0; i < freewayLength; i++) {
        cin >> tempInput;
        segments.push_back(tempInput);
    }
    
    for(int i = 0; i < numberOfTestCases; i++) {
        cin >> start >> end;
        
        for(int i = start; i <= end; i++) {
            if(segments[i] < minSegLength){
                minSegLength = segments[i];
                largestVehicle = minSegLength;
            }
        }
        
        cout << largestVehicle << endl;
        
        // Reset variables
        largestVehicle = 0;
        minSegLength = 9;
    }
    
    return 0;
}