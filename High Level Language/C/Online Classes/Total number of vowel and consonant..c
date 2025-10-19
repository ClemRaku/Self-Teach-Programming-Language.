#include<stdio.h>

int main() {
    char str[100];
    int i, l, vowel = 0, consonant = 0;
    printf("Enter string: ");
    fgets(str, sizeof(str), stdin);
    l = strlen(str);
    for (i = 0; i < l; i++) {
        if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')) {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U') {
                vowel++;
            } else {
                consonant++;
            }
        }
    }
    printf("Total Number of vowels: %d\n", vowel);
    printf("Total Number of Consonants: %d\n", consonant);

    return 0;
}
