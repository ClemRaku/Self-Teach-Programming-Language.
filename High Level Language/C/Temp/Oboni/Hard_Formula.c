#include<stdio.h>
#include<math.h>
int main()
{
    float a, b, c, n;
    float x; //oboni forgot to write this.

    scanf("%f", & a);
    scanf("%f", & b);
    scanf("%f", & c);
    scanf("%f", & n);

    //process
    x = (pow(pow(b, c), 1/n) + pow(pow(c, n), 1/b)) /  (sqrt(b*b - 4*a*c));

    //output
    printf("%f", x);

}