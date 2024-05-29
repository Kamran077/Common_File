#include <stdio.h>
#include <stdlib.h>

int main()
{
    int marks[5];
    int sum = 0;
    int divide;
    for(int i = 1 ; i <= 5 ; i++)
    {
        printf("Enter the %d. student's mark  : ",i);
        scanf("%d", &marks[i]);
    }

    for(int j = 1 ; j <= 5 ; j++)
    {
        sum+=marks[j];
    }
    divide = sum / 5;
    printf("Student average is : %d",divide);

    return 0;
}
