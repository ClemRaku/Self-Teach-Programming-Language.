#include<stdio.h>
int main()
{
    int space;
    int search;
    int check=0;
    int left, right, middle;
    printf("Enter the amount of values you want to enter in the array = ");
    scanf("%d", & space);
    int array[space];
    for(int i=0; i<space; i++)
    {
        printf("Enter the value of %d position = ", i+1);
        scanf("%d", & array[i]);
    }
    printf("Which value do you want to find?\n");
    scanf("%d", & search);
    left = 0;
    right = space;

    while(left<=right)
    {
        middle= (left+right)/2;
        if(array[middle] == search)
        {
            printf("The value has been found.\nThe position of the value is %d", middle+1);
            check = 1;
            break;

        }
        else if(search>array[middle])
        {
            left = middle + 1;
        }
        else
        {
            right = middle -1;
        }
    }
    if(check != 1)
    {
        printf("The value hasn't been found");
    }
    return 0;
}



