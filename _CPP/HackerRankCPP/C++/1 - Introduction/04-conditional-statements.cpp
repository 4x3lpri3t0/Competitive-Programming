#include <bits/stdc++.h>
using namespace std;

int ConditionalStatements() {
	string a[] = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	int check;

	cin >> check;

	if (check > 9) {
		cout << "Greater than 9";
	}
	else {
		cout << a[check];
	}

    return 0;
}