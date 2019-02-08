#include <cstdio>
#include <cstring>
#include <sstream>
#include <string>
#include <iostream>
using namespace std;

// https://uva.onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=24&page=show_problem&problem=2899
int main() {
	int n, T;
	cin >> T;
	for (int t = 1; t <= T; t++) {
		cin >> n;
		int max = -1, a;
		for (int i = 0; i < n; i++) {
			cin >> a;
			if (a > max)
				max = a;
		}
		cout << "Case " << t << ": " << max << endl;
	}
	return 0;
}