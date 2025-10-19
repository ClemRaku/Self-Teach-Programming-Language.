#include<stdio.h>
int main()
{
    int space;
    int temp;

    printf("How many storage space in the array? \n");
    scanf("%d", & space);
    int array[space];
    for(int i=0; i<space; i++)
    {
        printf("Enter the %d position value: ", i+1);
        scanf("%d", & array[i]);
    }
    for(int i = 0; i<space-1; i++)
    {
        for(int j=0; j<space-1; j++)
        {
            if(array[j]>array[j+1])
            {
                temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;

            }
        }
    }
    printf("The sorted array is\n");
    for(int i = 0; i<space; i++)
    {
        printf("%d, ", array[i]);
    }

    return 0;
}


