#include <bits/stdc++.h>
using namespace std;

int SolveMeSecond(int a, int b) {
  return a + b;
}

int Solve2() {
  int num1, num2, sum, t;

  cin >> t;

  for (int i = 0; i < t; i++) {
    cin >> num1 >> num2;
    
    sum = SolveMeSecond(num1, num2);
    
    cout << sum << endl;
  }

  return 0;
}