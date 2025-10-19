#include<stdio.h>
int main(){
int end;
int sum=2;
int temp;

printf("Upto which number should we find the prime numbers?");
scanf("%d", &end);

for(int i=3; i<=end; i++){
    temp = 0;
    for(int a=2; a<i; a++){
        if(i%a==0){
            temp++;
            break;
        }
    }
    if(temp == 0){
        sum= sum + i;
    }
    else{
        continue;
    }
}


printf("The sum of prime numbers is %d", sum);

return 0;
}
