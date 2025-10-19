
#include <stdio.h>

int main() {
    int num;
    int check = 0;
    printf("Will be checking whether your input, is a prime number or not. \nEnter a number: ");
    scanf("%d", &num);

    if (num == 1) {
        printf("Number is not a prime\n");
        return 0;
    }

    for (int i=2; i<num; i++) {
        if (num % i == 0) {
            check = 1;
            break;
        }
    }

    if (check == 0) {
        printf("Prime number\n");
    } else {
        printf("Not a prime\n");
    }

    return 0;
}


