#include <stdio.h>
#include <stdlib.h>
#include "MathFunctions.h"

int main()
{
    int choose,x,y;
    menu();
    printf("\nChoose one number among 1 - 4 : ");
    scanf("%d",&choose);
    printf("\n");

    switch(choose)
    {
    case 1:
        printf("Enter the two numbers : \n");
        scanf("%d %d",&x,&y);
        printf("Max value is %d\n",max(x,y));
    break;

    case 2:
        printf("Enter the two numbers : \n");
        scanf("%d %d",&x,&y);
        printf("Min value is %d\n",min(x,y));
    break;

    case 3:
        printf("Enter the number : \n");
        scanf("%d",&x);
        printf("This number's square is %d\n",square(x));
    break;

    case 4:
        printf("Enter the number : \n");
        scanf("%d",&x);
        printf("This number's cube is %d\n",cube(x));
    break;

    default:
        printf("Wrong number please try again...");
    break;

    }


    return 0;
}

void menu()
{
    printf("\n");
    printf("**********\n");
    printf("   MENU   \n");
    printf("**********\n");
    printf("1 - Maximum\n");
    printf("2 - Minimun\n");
    printf("3 - Square\n");
    printf("4 - Cube\n");
}

int max(int x, int y)
{
    if(x < y)
    {
        return y;
    }
    else
    {
        return x;
    }
}

int min(int x, int y)
{
    if(x < y)
    {
        return x;
    }
    else
    {
        return y;
    }
}

int square(int x)
{
    return x*x;
}

int cube(int x)
{
    return x*x*x;
}























