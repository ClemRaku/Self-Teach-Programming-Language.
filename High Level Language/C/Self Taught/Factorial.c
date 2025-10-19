#include<stdio.h>
int main()
{
    unsigned long long int factorial = 1;
    unsigned long long int i, all, lastfour, input;

    //Scanning factorial number
    printf("Enter: ");
    scanf("%llu", & input);


    //Factorial work being done
    for(i = 1; i<=input; i++){
        factorial = factorial*i;
    }


    //all the last four digits = first four digits before 8!
    if(input<=7 && input>=1){
        printf("%llu", factorial);
    }

    //storing last four digits
    else if(input>=8 && input<=19){
        lastfour = factorial % 10000;
        printf("%04llu", lastfour);

    }
    //all last four digits after 20! are 0000
    else if(input>=20 && input<=999){
        printf("0000");
    }



    return 0;
}
