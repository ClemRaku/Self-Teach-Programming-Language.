#include<stdio.h>

int main(){

char *s = "HI!";
printf("%c", *s); //This is same as 's[0]'
printf("%c", *(s+1));//This is same as 's[1]'
printf("%c\n", *(s+2));//This is same as 's[2]'


return 0;
}
