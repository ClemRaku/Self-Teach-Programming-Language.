#include <stdio.h>
#include <math.h>

int main() {
    float radius;
    float perimeter;

    printf("Value of the radius is");
    scanf("%f", & radius);
    perimeter = M_PI * pow(radius,2);

    printf("The perimeter is %f", perimeter);



 return 0;

 }
