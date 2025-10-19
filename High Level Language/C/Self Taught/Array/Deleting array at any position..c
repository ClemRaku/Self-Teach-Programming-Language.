#include<stdio.h>
int main(){
    int arrsize;
    //Inputting array size
    printf("Array size: ");
    scanf("%d", & arrsize);

    int arr[arrsize];

    //Inputting array
    for(int i=0; i<arrsize; i++){
        printf("Enter the %d number position value: ", i+1 );
        scanf("%d", &arr[i]);
    }

    int arrdel;
    printf("Delete which position element: ");
    scanf("%d", & arrdel);
    arrdel = arrdel -1;


    //Moving all the elements of the array.
    for(int j=arrdel; j<arrsize; j++){
        arr[j] = arr[j+1];
    }

    printf("The new array is: ");
    for(int a = 0; a<arrsize-1; a++){
        printf("%d ", arr[a]);
    }


return 0;
}
