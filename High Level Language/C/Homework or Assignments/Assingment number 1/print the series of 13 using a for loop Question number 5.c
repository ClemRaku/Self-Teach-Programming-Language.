#include<stdio.h>
int main(){

int i;
char symbol;
printf("SERIES OF 13 \n");
printf("For increment series, press '+',\nFor decrement series, press '-'\n");
scanf("%c", & symbol);

if(symbol == '+'){
    for(i = 0; i <= 130; i= 13+i){
        printf("%d\n", i);
    }
}
else if(symbol == '-'){
    for(i = 130; i >= 0; i=i-13){
        printf("%d\n", i);
    }
}
else{
    printf("Invalid input. Please try again.");
}
return 0;
}
