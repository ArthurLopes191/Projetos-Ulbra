#include <stdio.h>

int main(){
    int n1, n2, sub;
    printf ("Digite  N1\n");
    scanf ("%d%*c", &n1);
    printf ("Digite N2\n");
    scanf ("%d%*c", &n2);
    sub = n1-n2;
    printf ("O valor da subtracao eh %d \n", sub);

    return 0;
}