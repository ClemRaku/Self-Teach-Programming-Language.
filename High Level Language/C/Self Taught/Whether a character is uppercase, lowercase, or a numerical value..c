#include <stdio.h>

int main() {
    char ch;

    // Read a character from the user
    printf("Enter a character: ");
    scanf(" %c", &ch);

    // Check if the character is an uppercase alphabet
    if (ch >= 'A' && ch <= 'Z') {
        printf("The entered character is an uppercase alphabet.\n");
    }
    // Check if the character is a lowercase alphabet
    else if (ch >= 'a' && ch <= 'z') {
        printf("The entered character is a lowercase alphabet.\n");
    }
    // Check if the character is a numerical value
    else if (ch >= '0' && ch <= '9') {
        printf("The entered character is a numerical value.\n");
    }
    // If the character is none of the above
    else {
        printf("The entered character is not an alphabet or a numerical value.\n");
    }

    return 0;
}
