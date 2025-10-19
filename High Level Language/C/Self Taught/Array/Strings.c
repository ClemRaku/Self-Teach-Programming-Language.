#include<stdio.h>
int main(){

/*  There are 4 values in this string
    The four values are, H, i, !, /0
    '/0', is a null character           */
char s[] = "Hi!";

printf("%s\n\n\n", s);


//'c' is a format specifier to show just one character in a string of characters.
printf("%c\n", s[0]);
printf("%c\n", s[1]);
printf("%c\n", s[2]);
printf("%c\n", s[3]);
printf("%c\n", s[4]);//This is a null character, isn't necessary to show.




return 0;
}
