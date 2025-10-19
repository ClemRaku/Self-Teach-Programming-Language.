#include <stdio.h>

int main() {
    int input, remainder;
    int result = 0;

    printf("Enter a number: \n");
    scanf("%d", & input);

    for(int i = input; i>0; i=i/10){
        remainder= i%10;
        result = result*10 + remainder;
    }
    if(result==input){
        printf("Number is Palindrome\n");
    }
    else{
        printf("Number isn't a Palindrome\n");
    }

    return 0;
}
