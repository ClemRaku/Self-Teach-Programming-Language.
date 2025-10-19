#include<stdio.h>//taking in arrays from user, and showing them. there's a separate code in the assignment folder.
int main()
{
    int arr[9];
    int i;
    int sum=0;
    for(i=0; i<9; i++)
    {
        printf("Enter: ");
        scanf("%d", & arr[i]);
    }
    printf("The numbers are, \n");
    for(i=0; i<9; i++)
    {
        printf("%d\n",arr[i]);
    }
    return 0;
}
