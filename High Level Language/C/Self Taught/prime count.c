#include<stdio.h>
int main(){
int end;
int count=1;
int temp;

printf("Up to which number should we find the amount of prime numbers?");
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
        count= count + 1;
    }
    else{
        continue;
    }
}


printf("There are %d prime numbers within %d", count, end);

return 0;
}
