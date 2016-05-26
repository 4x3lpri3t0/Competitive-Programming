#include <stdio.h>
#include <stdlib.h>

void update(int *a,int *b) {
    // Complete this function
    int resultSum = *a + *b;
    printf("%d\n", resultSum);
    
    int resultDif = abs(*a - *b);
    printf("%d", resultDif);
}

int main() {
    int a, b;
    int *pa = &a, *pb = &b;
    
    scanf("%d %d", &a, &b);
    update(pa, pb);
    //printf("%d\n%d", a, b);

    return 0;
}