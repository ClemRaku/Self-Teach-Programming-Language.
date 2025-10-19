#include<stdio.h>
int main()
{
    int a, b, c;
    scanf("%d %d %d", & a, & b, & c);
    if(a > b && a > c)
    {
        printf("a is bigger");
    }
    else if(b >c && b > a)
    {
        printf("b is bigger");
    }
    else if(c > a && c > b)
    {
        printf("c is bigger");
    }
    else
    {
        printf("Numbers are equal");
    }
}