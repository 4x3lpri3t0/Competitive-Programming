#include <cstdio>
#include <cstring>
#include <sstream>
#include <string>
#include <iostream>
using namespace std;

// https://uva.onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=24&page=show_problem&problem=2493
int main() {
	int K;
	cin >> K;
	while (K != 0) {
		int N, M;
		cin >> N >> M;
		while (K--) {
			int x, y;
			cin >> x >> y;

			if (x == N || y == M)
				cout << "divisa";
			else if (x > N && y > M)
				cout << "NE";
			else if (x > N && y < M)
				cout << "SE";
			else if (x < N && y > M)
				cout << "NO";
			else
				cout << "SO";
			
			cout << endl;
		}

		cin >> K;
	}
	
	return 0;
}