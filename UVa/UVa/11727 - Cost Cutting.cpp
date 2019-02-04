#include <cstdio>
#include <cstring>
#include <sstream>
#include <string>
#include <iostream>
#include <algorithm>
using namespace std;

// https://uva.onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=24&page=show_problem&problem=2827
int main() {
	int T, ar[3];
	cin >> T;
	
	for (int t = 1; t <= T; t++) {
		cin >> ar[0] >> ar[1] >> ar[2];
		sort(ar, ar + 3);
		cout << "Case " << t << ": " << ar[1] << endl;
	}

	return 0;
}