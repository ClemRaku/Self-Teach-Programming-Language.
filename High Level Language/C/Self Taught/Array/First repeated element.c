#include<stdio.h>
int main()
{
    int space;

    int repeated = 0;
    printf("How many storage space in the array? \n");
    scanf("%d", & space);
    int array[space];
    for(int i=0; i<space; i++)
    {
        printf("Enter the %d position value: ", i+1);
        scanf("%d", & array[i]);
    }
    for(int i = 0; i<space; i++)
    {
        for(int j=i+1; j<space; j++)
        {
            if(array[i]==array[j])
            {
                printf("The first repeated element in the array is, %d.", array[i]);

                repeated = 1;
                break;

            }
        }
    }
    if(repeated!=1)
    {
        printf("There is no repeated element in the given array.");
    }

    return 0;
}


