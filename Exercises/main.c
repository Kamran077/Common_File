#include <stdio.h>
#include <stdlib.h>

int main()
{
  int age;
  float height;
  char letter;

  printf("Please,Enter your age : ");
  scanf("%d",&age);

  printf("Please,Enter your height : ");
  scanf("%f",&height);

  printf("Please,Enter a letter : ");
  scanf(" %c",&letter);

  printf("Your age is %d.Your height is %.2f.Letter is %c.",age,height,letter);

  return 0;
}
