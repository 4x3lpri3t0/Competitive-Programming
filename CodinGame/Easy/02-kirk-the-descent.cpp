#include <iostream>

using namespace std;

int main()
{

    // game loop
    while (1) {
        int SX;
        int SY;
        cin >> SX >> SY; cin.ignore();
        int maxMountainIndex = -1;
        int maxMH = -1;
        for (int i = 0; i < 8; i++) {
            int MH; // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
            cin >> MH; cin.ignore();

            if(MH > maxMH) {
                maxMountainIndex = i;
                maxMH = MH;
            }
        }
        
        if(SX == maxMountainIndex) {
            cout << "FIRE" << endl;
        } else {
            cout << "HOLD" << endl;
        }

        // Write an action using cout. DON'T FORGET THE "<< endl"
        // To debug: cerr << "Debug messages..." << endl;

        //cout << "HOLD" << endl; // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
    }
}