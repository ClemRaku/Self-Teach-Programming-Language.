#include <stdio.h>

int main() {
    char name[30];
    printf("Enter Name ");
    fgets(name, sizeof(name), stdin);
    printf("Name: ");
    puts(name); //display string

    return 0;
}
