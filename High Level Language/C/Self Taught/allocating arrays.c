////Resizing array

#include<stdio.h>
#include<stdlib.h>

int main()
{
    /* '*' is used to indicated the address of the variable 'list'
    'malloc' is the function that allocated memory*/
    int *list = malloc(3 * sizeof(int));


    //If by any chance 'malloc' returns a zero value
    if(list == NULL)
    {
        return 1;
    }




    list[0] = 1;
    list[1] = 2;//the location or '[ ]' becomes 1*4 = 4
    list[2] = 3;//the location or '[ ]' becomes 2*4 = 8



    //Allocating memory for extra values to be inputted into the array 'list'
    int *tmp = malloc(4 * sizeof(int));
    if(tmp == NULL)
    {
        free(list); //'free' deallocates the values of 'list'
        return 1;
    }
    for(int i = 0; i<3; i++)
    {
        tmp[i] = list[i]; //copying all the values in 'list' into 'tmp', since 'tmp' has more space

    }
    tmp[3] = 4;

    free(list);
    list = tmp;



    for(int i = 0; i<4; i++)
    {
        printf("%d\n", list[i]);

    }

    free(list);


    return 0;
}
