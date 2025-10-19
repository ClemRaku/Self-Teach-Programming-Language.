//Write a program to print the following numbers in reverse order: 34 56 54 32 67 89 90 32 21


#include<stdio.h>
int main(){
int numbers[9]= {34, 56, 54, 32, 67, 89, 90, 32, 21};

printf("The not reverse order is, ");
for(int i=0; i<9; i++){
    printf("%d, ", numbers[i]);
}

printf("\n");

printf("The reverse order is ");
for(int i=8; i>=0; i--){
    printf("%d, ", numbers[i]);
}

return 0;
}
