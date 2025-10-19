#include <stdio.h>
#include<string.h>

int main()
{
    char integar[11];
    char comma = ',';
    printf("Enter the digits = ");
    fgets(integar, sizeof(integar),stdin);
    if (integar[strlen(integar) - 1] == '\n')//deleting the extra length caused by a new line
    {
        integar[strlen(integar) - 1] = '\0';
    }//making sure strlen is 9 to begin with
    printf("!! strlen is %d !!\n", strlen(integar));


    for(int i = strlen(integar)-1; i>=6; i--)//comma placed before the last 3 digits
    {
        integar[i+1]= integar[i];
        if(i==6)
        {
            integar[i]= comma;
        }
    }//strlen has become 10 due to 'comma'
    printf("!! strlen is %d before the last 3rd comma!!\n", strlen(integar));

    for(int i = strlen(integar)-1; i>=3; i--) //comma placed before the last 6 digits
    {
        integar[i+1] = integar[i];
        if(i==3)
        {
            integar[i] = comma;
        }
    }//strlen has become 11 due to two previous 'comma'
    printf("!! strlen is %d before the last 6th comma!!\n", strlen(integar));
    printf("%s", integar);



    return 0;
}
