#include<stdio.h>
int main()
{
    int arrsize;
    printf("Array size: ");
    scanf("%d", & arrsize);

    int arr[arrsize];

    for(int i=0; i<arrsize; i++)
    {
        printf("Enter the %d position element: ", i+1);
        scanf("%d", &arr[i]);
    }
//BUBBLE SORT
    int temp;
    for(int j=0; j<arrsize; j++)
    {
        for(int i=0; i<arrsize; i++)
        {
            if(arr[i]>arr[i+1])
            {
                temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;

            }

        }
    }

//BINARY SEARCH
    int find, left, right, middle, found = 0;

    printf("Find: ");
    scanf("%d", & find);

    left = 0;
    right = arrsize;

    while(left<=right)
    {
        middle = (left + right) / 2;
        if(find == arr[middle])
        {
            printf("FOUND!\n");
            found++;
            break;
        }
        else if(find > middle)
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }

    }
    if(found == 0)
    {
        printf("NOT FOUND!\n");
    }





    return 0;
}
