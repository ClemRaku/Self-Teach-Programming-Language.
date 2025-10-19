#include<stdio.h>
int main(){
char character;

printf("Enter the character: \n");
scanf("%c", &character);

if( (character <= 'Z') && (character >= 'A') ){
    printf("The character is Uppercase.");
}
else if( (character <= 'z') && (character >= 'a') ){
    printf("The character is Lowercase.");
}
else{
    printf("Invalid Input.");
}

return 0;

}
