#include<stdio.h>
#include<string.h>

int main(){

char s[100];
char t[100];

printf("Enter s = ");
fgets(s, sizeof(s), stdin);
printf("Enter t = ");
fgets(t, sizeof(t), stdin);


/* 'strcmp' means comparing two strings. If the two strings are same, then it is zero.
    If positive, then one letter is after the other, negative if one
    letter is before the other.
*/
if(strcmp(s, t)==0){//Only the addresses of the strings are compared, not the alphabets.
    printf("Same\n");
}
else{
    printf("Different\n");
}
return 0;
}
