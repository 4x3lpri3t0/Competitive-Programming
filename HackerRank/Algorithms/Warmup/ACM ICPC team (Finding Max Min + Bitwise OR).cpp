#include <iostream>

using namespace std;

int main() {
    int N, M, maxNumOfTopics = 0, teamsWithMax = 0;
    
    cin >> N >> M;
    string peopleArray[N];
    
    for(int i = 0; i < N; i++) {
        cin >> peopleArray[i];
    }
    
    for(int i = 0; i < N-1; i++) {
        for(int j = i+1; j < N; j++) {
            int numOfTopicsInCommon = 0;
            
            for (int k = 0; k < M; k++) {
                // Convert to ints:
                int currentTopicA = peopleArray[i][k] - '0';
                int currentTopicB = peopleArray[j][k] - '0';

                // Bitwise OR
                if(currentTopicA | currentTopicB) {
                    numOfTopicsInCommon++;
                }
            }
            
            // Finding Max Min
            if(numOfTopicsInCommon > maxNumOfTopics) {
                maxNumOfTopics = numOfTopicsInCommon;
                teamsWithMax = 1;
            } else if(numOfTopicsInCommon == maxNumOfTopics) {
                teamsWithMax++;
            }
        }
    }
    
    cout << maxNumOfTopics << endl << teamsWithMax;
    
    return 0;
}