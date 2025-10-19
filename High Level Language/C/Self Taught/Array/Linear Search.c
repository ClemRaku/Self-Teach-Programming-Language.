#include<stdio.h>
int main()
{
    int search;
    int check=0;
    int space;
    printf("How many values do you want to enter in the Array ?\n");
    scanf("%d", & space );

    int array[space];



    for(int i=0; i<space; i++)
    {
        printf("Enter the value of %d position = ", i+1);
        scanf("%d", & array[i]);
    }
    printf("Which value do you want to find?\n");
    scanf("%d", & search);
    for(int i=0; i<space; i++)
    {
        if(search==array[i])
        {
            printf("The value has been found, and the position of the value is %d", i+1);
            check=1;
            break;
        }
    }

    if(check!=1)
    {
        printf("Unfortunately the array has not been found");
    }

    return 0;
}



