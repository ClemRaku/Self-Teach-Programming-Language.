/* Write a program to delete any element from middle of an array */

#include<stdio.h>
int main()
{

    int array[6];
    int i;
    int temp;
    printf("The array has 6 storage spaces, hence please enter 6 values to store in the array.\n\n");
    for(i=0; i<6; i++)
    {
        printf("Enter the value of the %d number array = ", i+1);
        scanf("%d", & array[i]);
    }
    int k=3;
    temp = array[2];
    int j;
    for(j=k-1; j<=5; j++)
    {
        array[j]= array[j+1];
    }
printf("\n\n");

    for(i=0; i<5; i++)
    {
        printf("%d ", array[i]);

    }
    printf("\n\n");
    printf("The middle of the Array, 3rd position, who's value was %d, has been removed. ", temp);
    return 0;
}

