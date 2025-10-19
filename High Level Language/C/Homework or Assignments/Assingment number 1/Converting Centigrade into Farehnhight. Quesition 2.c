#include<stdio.h>

int main(){
    float centigrade, fahrenheit;

    printf("Enter the Centigrade: \n");
    scanf("%f", & centigrade);
    fahrenheit = centigrade * 1.8 + 32;

    printf("Value of Fahrenheit is %f", fahrenheit);

return 0;
}
