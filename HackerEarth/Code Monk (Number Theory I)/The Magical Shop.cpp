#include <iostream>
using namespace std;

int main()
{
    long long A, B, total = 0;
    string daysAllowed;
    
    cin >> A >> B >> daysAllowed;
    
    for(int i = 0; i < daysAllowed.size(); i++){
        if(daysAllowed[i] == '1') { // Monk allowed me to go to the magical shop
            total = ((total % B) + (A % B)) % B;
        }
        
        A = ((A % B) * (A % B)) % B;
    }
    
    cout << total % B;
    
    return 0;
}
