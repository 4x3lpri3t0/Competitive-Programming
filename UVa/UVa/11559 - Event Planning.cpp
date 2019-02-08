#include <cstdio>
#include <algorithm>
#include <climits>
using namespace std;

// https://uva.onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=24&page=show_problem&problem=2595
int main() {
	int N, B, H, W, p, ans, cap;

	while (scanf("%d %d %d %d", &N, &B, &H, &W) == 4) {
		ans = std::numeric_limits<int>::max();

		for (int i = 0; i < H; ++i) {
			scanf("%d", &p);
			cap = 0;

			for (int j = 0, x; j < W; ++j) {
				scanf("%d", &x);
				cap = max(cap, x);
			}

			ans = min(ans, N * p);
		}

		if (ans > B)
			puts("stay home");
		else
			printf("%d\n", ans);
	}

	return 0;
}