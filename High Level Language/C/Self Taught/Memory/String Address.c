#include<stdio.h>

int main(){

/*  There are 4 values in this string
    The four values are, H, i, !, /0
    '/0', is a null character           */
char s[] = "Hi!";

printf("%p\n\n\n", s);//Shows the address of the start of the whole string
printf("%p\n\n\n", &s[0]);//shows the address of just the character, 'H'
//Both values should be the same.


//Now lets show the addresses of the other 3 characters in the str, including the address of the null value
printf("%p\n", &s[1]);
printf("%p\n", &s[2]);
printf("%p\n\n\n", &s[3]);



//we can write, 'st[]' like '*st'. It's the same.

char *st = "Hi!";

printf("%s", st);//'&' isn't needed due to the fact, that 'st' is a string, and not a character.


return 0;
}
