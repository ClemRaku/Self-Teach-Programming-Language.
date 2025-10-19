#include<stdio.h>
#include<string.h>

int main(){

char s[100];
char t[100];

printf("Enter s = ");
fgets(s, sizeof(s), stdin);
printf("Enter t = ");
fgets(t, sizeof(t), stdin);

 // Remove newline characters from strings
    s[strcspn(s, "\n")] = '\0';
    t[strcspn(t, "\n")] = '\0';


//Showing that, even though the strings are same, the addresses are different.
printf("%p\n\n", s);
printf("%p\n\n", t);
printf("\n\n");
printf("%s and %s.\n", s, t);

return 0;
}
