#include<stdio.h>
#include<string.h>

int main()
{

    char number[13];
    char comma = ',';
    int length;
    int repeat = 0;
    char numwithcomma[25]; //increased the space to decrease errors
    int nwc = 0;
    int newlenght;
    printf("Enter a number: ");
    fgets(number, sizeof(number), stdin);

    if(number[strlen(number)-1]=='\n')
    {
        number[strlen(number) -1] = '\0';
    }//erasing any extra length

    length = strlen(number);

    for(int i=length-1; i>=0; i--)
    {

        if(repeat==3)//Adding commas
        {
            numwithcomma[nwc] = comma;
            nwc++;
            repeat=0;
        }

            numwithcomma[nwc] = number[i];
            nwc++;
            repeat++;


    }
    numwithcomma[nwc] = '\0'; //wrote this cuz ChatGPT said so.

    newlenght = strlen(numwithcomma);

    for(int i=newlenght-1; i>=0; i--)
    {
        printf("%c", numwithcomma[i]);
    }



    return 0;
}
