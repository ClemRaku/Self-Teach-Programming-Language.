#include <stdio.h>
int main() {
   int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
   int sum, i;
   sum = 0;
   for(i = 0; i <= 9; i++)
 {
      sum = sum + array[i];
   }
   printf("Sum of array is %d.", sum);
   return 0;
}
