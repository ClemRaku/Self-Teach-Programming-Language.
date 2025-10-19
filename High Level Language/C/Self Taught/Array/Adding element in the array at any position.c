#include<stdio.h>
int main()
{
    int space;
    printf("How many values do you want to put in the array? \n");
    scanf("%d", & space);

    //increasing the size of the user's array
    int arraspace;

    arraspace = space + 1;
    int array[arraspace];
//Inputing array values
    for(int i=0; i<space; i++)
    {
        printf("Enter the %d position value = ", i+1);
        scanf("%d", & array[i]);
    }

    printf("\n\n");
//finding out the position
    int position;
    printf("Which position would you like to add a value in the array? \n");
    scanf("%d", & position);
//finding out the value
    int value;
    printf("What value would you like to add? \n");
    scanf("%d", & value);


//pushing all the values back one space
for(int i=space; i>=position; i--){
    array[i+1] = array[i];
}

//adding the value in that position
array[position-1] = value;

printf("\n\n\n");
printf("The array is \n\n");
for(int i = 0; i<space+1; i++){
    printf("%d ", array[i]);
}

    return 0;
}
