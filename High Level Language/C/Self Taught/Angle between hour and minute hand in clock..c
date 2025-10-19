/*Given a time (hours as H and minutes as M), determine the smaller angle between the two hands of a clock showing the time and print it.*/




#include<stdio.h>
int main()
{
    float H, M;
    float angle;
    scanf("%f", &H);
    scanf("%f", &M);
    if(H>=0&&H<=12&&M>=0&&M<=60)
    {
        angle = (11*M-60*H)/2;
        if(angle<0)
        {
            angle = angle*(-1);
            if(angle>180)
            {
                angle = 360 - angle;
            }
        }
        else
        {
            if(angle>180)
            {
                angle = 360 - angle;
            }
        }
    printf("%f", angle );
    }
    else
    {
        printf("Invalid Input.");
    }

    return 0;
}
