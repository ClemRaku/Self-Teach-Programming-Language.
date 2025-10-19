//Multiplication of two matrices.

#include<stdio.h>
int main(){

int row1, coloumn1, row2, coloumn2, row, coloumn;

//First matrix's rows & columns
printf("Enter the amount of rows & columns of the first matrix.\n");
printf("Rows: ");
scanf("%d", &row1);
printf("Columns: ");
scanf("%d", &coloumn1);
printf("\n\n");
//Second matrix's rows & columns
printf("Enter the amount of rows & columns of the second matrix.\n");
printf("Rows: ");
scanf("%d", &row2);
printf("Columns: ");
scanf("%d", &coloumn2);
printf("\n\n");

if(coloumn1==row2){
//Entering elements of the first matrix
printf("Enter the rows & columns of the first matrix\n\n");
int matrix1[row1][coloumn1];
for(int i=0; i<row1; i++){
    for(int j=0; j<coloumn1; j++){
        printf("Enter %d number row and %d number column: ", i+1, j+1);
        scanf("%d", &matrix1[i][j]);
    }
}
printf("\n");
//Entering elements of the second matrix
printf("Enter the rows & columns of the second matrix\n\n");
int matrix2[row2][coloumn2];
for(int x=0; x<row2; x++){
    for(int y=0; y<coloumn2; y++){
        printf("Enter %d number row and %d number column: ", x+1, y+1);
        scanf("%d", &matrix2[x][y]);
    }
}

//Multiplication
int matrix[row1][coloumn2];
for(int i = 0; i<row1; i++){
    for(int x = 0; x<coloumn2; x++){
        matrix[i][x] = 0;
        for(int y=0; y<coloumn1;y++){
            matrix[i][x] = matrix[i][x] + ( matrix1[i][y]*matrix2[y][x]);
        }
    }
}
printf("\nThe resultant Matrix is: \n");
//printing the resultant matrix
for(int i = 0; i<row1; i++){
    for(int j = 0; j<coloumn2; j++)
    {
        printf("%d number row and %d number column: %d\n\n", i+1, j+1, matrix[i][j]);
    }
}

}
else{
    printf("Unfortunately the two matrices are impossible to multiply.");
}

return 0;
}
