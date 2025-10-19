#include<stdio.h>
int main()
{

    int space;
    printf("Enter the amount how many values you wish to enter in the array: ");
    scanf("%d", &space);
    int arr[space];

    for(int i=0; i<space; i++)
    {
        printf("Enter the %d position value : ", i+1);
        scanf("%d", &arr[i]);
    }
    int amount; //This is the amount of elements present in the Array.
    int storage; //Storage bits occupied by the elements in the Array.
    amount = sizeof(arr)/sizeof(arr[0]);
    storage = sizeof(arr);
    printf("The amount of elements in the array is %d.\nThe amount of storage space in bits is %d.", amount, storage);

    return 0;
}
