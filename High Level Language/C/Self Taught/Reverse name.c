#include<stdio.h>
#include<string.h>

char *strrev(char *string)
{
    int length = strlen(string);
    int start = 0;
    int end = length - 1;

    while (start < end)
    {
        char temp = string[start];
        string[start] = string[end];
        string[end] = temp;
        start++;
        end--;
    }

    return string; // reverse the string in place and return it
}

int main()
{
    char strrev[1000];

    printf("Enter the name: \n");
    scanf("%s", strrev);

    strrev(strrev);

    printf("The reversed name is: %s\n", strrev);

    return 0;
}
