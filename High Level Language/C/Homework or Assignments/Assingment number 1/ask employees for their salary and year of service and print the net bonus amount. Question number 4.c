#include<stdio.h>
int main(){
    float salary;
    float year;
    float bonus;

    printf("What's your salary?\n");
    scanf("%f", & salary);

    printf("How many years did you work here as an employee?\n");
    scanf("%f", & year);

    if(year > 3){
        bonus = salary * 1.08;
        printf("Your bonus salary is %f \n", bonus );
    }
    else{
        printf("You'll receive no bonus. Your salary is %f", salary);
    }

return 0;
}
