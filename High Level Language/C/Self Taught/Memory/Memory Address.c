#include<stdio.h>
int main(){

int n = 50;

/* '%p' is used as a format specifier, that is used to print or scan a Address of a value.
    '&' is used to locate the address. */
printf("%p\n\n\n", &n);

//OR

// We can use '*' asterisk to indicate a variable that it's a pointer variable, that points the 'p' variable towards the address of n AKA, '&n'
int *p = &n;
printf("%p\n\n\n", p);

//To show what is present in that pointer address.

//'*p' is going to the address of 'n' to show what is present in that address, which is '50'
printf("%d\n", *p);


return 0;
}
