/* Write a program to take two individual matrix (2D array) and show the summation of these two matrices */

#include<stdio.h>
int main()
{

    int row1, column1, row2, column2;
    //enter the rows and coloms for the first matrix
    printf("Let us enter the matrix configuration for the first matrix \n");
    printf("Enter the amount of rows = ");
    scanf("%d", &row1);
    printf("Enter the amount of columns = ");
    scanf("%d", &column1);
    //enter the rows and coloms for the second matrix
    printf("Let us enter the matrix configuration for the second matrix \n");
    printf("Enter the amount of rows = ");
    scanf("%d", &row2);
    printf("Enter the amount of columns = ");
    scanf("%d", &column2);
    int array1[row1][column1], array2[row1][column1],sum[row1][column1];
    if(row1==row2 && column1==column2)
    {

        printf("Let us take the values of the first matrix\n");
        for(int i=0; i<row1; i++)
        {
            for(int k=0; k<column1; k++)
            {
                printf("Enter the value of the %d.%d. number matrix = ", i+1, k+1);
                scanf("%d", &array1[i][k]);
                printf("\n");

            }
        }
        printf("\n\n");
        printf("Now let us take values of the second matrix\n");
        for(int i=0; i<row2; i++)
        {
            for(int k=0; k<column2; k++)
            {
                printf("Enter the value of the %d.%d. number matrix = ", i+1, k+1);
                scanf("%d", &array2[i][k]);
                printf("\n");

            }
        }

        /* The summation is taking place */

        for(int i=0; i<row1; i++)
        {
            for(int k=0; k<column1; k++)
            {
                sum[i][k] = array1[i][k]+array2[i][k]; //summation is taking place here.

            }
        }
        //summation done in the above loop

        //time to print below
        printf("Let us show you the summation of the two matrices that you have entered \n\n");
        for(int i=0; i<row1; i++)
        {
            for(int k=0; k<column1; k++)
            {
                printf("The summation value of the %d.%d. matrix is = %d\n", i+1, k+1, sum[i][k]);

            }
        }
    }

    else
    {
        printf("!!!!!!\n\n");
        printf("Since the amount of rows and columns are not equal. Hence the summation is impossible.\n");
    }

    return 0;
}
