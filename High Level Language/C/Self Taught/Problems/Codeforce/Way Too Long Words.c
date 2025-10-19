/* Sometimes some words like "localization" or "internationalization" are so long that writing them many times in one text is quite tiresome.

Let's consider a word too long, if its length is strictly more than 10 characters. All too long words should be replaced with a special abbreviation.

This abbreviation is made like this: we write down the first and the last letter of a word and between them we write the number of letters between the first and the last letters. That number is in decimal system and doesn't contain any leading zeroes.

Thus, "localization" will be spelt as "l10n", and "internationalization» will be spelt as "i18n".

You are suggested to automatize the process of changing the words with abbreviations. At that all too long words should be replaced by the abbreviation and the words that are not too long should not undergo any changes.

Input
The first line contains an integer n (1 ≤ n ≤ 100). Each of the following n lines contains one word. All the words consist of lowercase Latin letters and possess the lengths of from 1 to 100 characters.

Output
Print n lines. The i-th line should contain the result of replacing of the i-th word from the input data. */


#include<stdio.h>
#include<string.h>
int main(){

int n, middleint;
printf("Amount of strings: ");
scanf("%d", & n);

getchar();

char word[n][110];//array[number of array][size of array];
for(int i=0; i<n; i++){
    printf("Enter the word: ");
    fgets(word[i], sizeof(word[i]), stdin);
    //removing new line if necessary
    if (word[i][strlen(word[i]) - 1] == '\n')
            word[i][strlen(word[i]) - 1] = '\0';
}

//lowercasing every alphabet
 for (int i = 0; i < n; i++) {
        for (int j = 0; j < strlen(word[i]); j++) {
            word[i][j] = tolower(word[i][j]);
        }
    }

int strlength[n];
//length of the strings
for(int i = 0; i<n; i++){
    strlength[i] = strlen(word[i]);
}

//printing the string lengths just to check (delete later)
for(int i = 0; i<n; i++){
    printf("length: %d\n", strlength[i]);
}

//shortening the word
for(int i = 0; i<n; i++){
    if(strlength[i]>10){

    middleint = strlength[i] -2;
    printf("%c%d%c\n", word[i][0], middleint, word[i][strlength[i]-1]);
}
else{
    printf("%s\n", word[i]);
}
}



return 0;
}
