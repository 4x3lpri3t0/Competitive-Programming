#include <bits/stdc++.h>
using namespace std;

int max_of_four(int a, int b, int c, int d) {
    return max(d, max(c, max(a, b)));
}

int Functions() {
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    int ans = max_of_four(a, b, c, d);
    printf("%d", ans);
    
    return 0;
}
