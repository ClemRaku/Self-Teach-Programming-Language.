/*printing out the maximum value in an int array */

#include<stdio.h>
int main(){
int arrsize;
printf("Array Size: ");
scanf("%d", &arrsize);

int arr[arrsize];
for(int i = 0; i<arrsize; i++){
    printf("Enter the %d number array: ", i+1);
    scanf("%d", &arr[i]);
}
    int store;
//Using the bubble sort algorithm
    for(int i = 0; i<arrsize-1; i++)
    {
        for(int j = 0; j<arrsize-1; j++)
        {
            if(arr[j]>arr[j+1])
            {
                store = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = store;
            }
            else{
                continue;
            }
        }
    }
//Print out the max element
printf("Maximum Number: %d", arr[arrsize-1]);

return 0;
}
