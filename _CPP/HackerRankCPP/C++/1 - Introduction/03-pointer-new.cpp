#include <bits/stdc++.h>
using namespace std;

void Update2(int *a, int *b) {
	// Complete this function 
	int first, second;
	first = *a;
	second = *b;

	*a = first + second;
	*b = abs(first - second);
}

int PointerNew() {
	int a, b;
	int *pa = &a, *pb = &b;

	scanf("%d %d", &a, &b);
	Update2(pa, pb);
	printf("%d\n%d", a, b);

	return 0;
}
