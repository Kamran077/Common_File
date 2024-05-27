#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num,pr;
    scanf("%d",&num);

    pr = (num/100)*((num/10)%10)*(num%10);
    printf("%d",pr);

    return 0;
}
