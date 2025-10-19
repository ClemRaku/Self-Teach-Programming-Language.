#include<stdio.h>
int main()
{
    int row1, row2, coloumn1, coloumn2, matrix1[2][2], matrix2[2][2], row, coloumn, matrix[2][2];

    //first matrix
    printf("Enter the values of the first matrix. \n\n");

    for(row1 = 0; row1<2; row1++)
    {
        for(coloumn1=0; coloumn1<2; coloumn1++ )
        {
            printf("Enter the %d Row & %d Column: ", row1+1, coloumn1+1);
            scanf("%d", & matrix1[row1][coloumn1]);
        }
    }

    //second matrix
    printf("\n\nEnter the values of the second matrix. \n\n");
    for(row2 = 0; row2<2; row2++)
    {
        for(coloumn2=0; coloumn2<2; coloumn2++ )
        {
            printf("Enter the %d Row & %d Column: ", row2+1, coloumn2+1);
            scanf("%d", & matrix2[row2][coloumn2]);
        }
    }

    //summation
    for(row = 0; row<2; row++)
    {
        for(coloumn=0; coloumn<2; coloumn++ )
        {
            matrix[row][coloumn] = matrix1[row][coloumn] + matrix2[row][coloumn];
        }
    }

    //printing
    printf("\n\nThe sum of the two matrices are:\n");
    for(row = 0; row<2; row++)
    {
        for(coloumn=0; coloumn<2; coloumn++ )
        {
            printf("%d number row & %d number coloumn: %d\n", row+1, coloumn+1, matrix[row][coloumn]);

        }
    }
    return 0;
}
