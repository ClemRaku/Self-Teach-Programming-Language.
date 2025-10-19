#include<stdio.h>
int main(){

float a, b, c;

printf("Enter first side, a \n");
scanf("%f", & a);

printf("Enter second side, b \n");
scanf("%f", & b);

printf("Enter third side, c \n");
scanf("%f", &c);

if((a + b > c) && (a + c > b) && (b + c > a)){
    printf("It is a Triangle");
}
else{
    printf("It's not a Triangle");
}

return 0;
}
