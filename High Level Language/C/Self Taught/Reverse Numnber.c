#include<stdio.h>

int main(){
int input, remainder;
    int result = 0;

    printf("Enter a number: \n");
    scanf("%d", & input);

    for(int i = input; i>0; i=i/10){
        remainder= i%10;
        printf("%d", remainder);
    }

return 0;
}
