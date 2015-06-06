#include <stdafx.h>
#include <iostream>

using namespace std;

int main() {
	int cnt = 0;

	for (int i = 0; i < 1000; i++) {
		if ((i % 3 == 0) || (i % 5 == 0)) {
			cnt = cnt + i;
		}
	}

	cout << cnt;

	return 0;
}