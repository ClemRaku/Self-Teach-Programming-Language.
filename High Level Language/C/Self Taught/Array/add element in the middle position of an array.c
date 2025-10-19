/* Write a program to add element in the middle position of an array */

#include<stdio.h>
int main()
{

    int array[6];
    printf("Array size = 6\n\n");
    int i;

    //Scanning the array
    for(i=0; i<5; i++)
    {
        printf("Enter the value of the %d number array = ", i+1);
        scanf("%d", & array[i]);
    }
    int k=2;//since array counting starts from 0 to 5, 2 is indeed the middle.

    int element;
    int j;
    printf("What value would you like to enter in the middle of the array? \n");
    scanf("%d", & element);

    //pushing all the elements by one space behind
    for(j=4; j>=k; j--)
    {
        array[j+1]= array[j];
    }


    //adding the element
    array[k]= element;
    for(i=0; i<=5; i++)
    {
        printf("%d ", array[i]);

    }

    return 0;
}

