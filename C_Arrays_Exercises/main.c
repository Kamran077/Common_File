#include <stdio.h>
#include <stdlib.h>

int main()
{
  int nums[3][3];
  for(int i = 0 ; i < 2 ; i++)
  {
      for(int j = 0 ; j < 3 ; j++)
      {
          printf("Enter the %d. row's %d. column's num : ",i,j);
          scanf("%d",&nums[i][j]);
      }
  }
  printf("***************************************\n");
  for(int i = 0 ; i < 2 ; i++)
  {
      for(int j = 0 ; j < 3 ; j++)
      {
          printf("%d\n",nums[i][j]);
      }
  }

    return 0;
}
