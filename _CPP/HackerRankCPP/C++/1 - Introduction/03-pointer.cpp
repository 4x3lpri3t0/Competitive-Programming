#include <bits/stdc++.h>
using namespace std;

void Update(int *a,int *b) {
    // Complete this function
    int resultSum = *a + *b;
    printf("%d\n", resultSum);
    
    int resultDif = abs(*a - *b);
    printf("%d", resultDif);
}

int Pointer() {
    int a, b;
    int *pa = &a, *pb = &b;
    
    scanf("%d %d", &a, &b);
	Update(pa, pb);
    //printf("%d\n%d", a, b);

    return 0;
}