#include <bits/stdc++.h>
using namespace std;

int SolveMeFirst(int a, int b) {
  return a + b;
}

int Solve1() {
  int num1, num2, sum;

  cin >> num1 >> num2;
  
  sum = SolveMeFirst(num1, num2);
  
  cout << sum;
  
  return 0;
}