#include<stdio.h>
int main()
{
    //declaration
    float fareidheight, kelvin;

    //input
    scanf("%f", & fareidheight);

    //process
    kelvin = 273 + 5*(fareidheight-32)/9;

    //output
    printf("%f", kelvin);

}