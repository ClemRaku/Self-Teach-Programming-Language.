int main()
{
    int array[10];
    printf("Let us enter the ten values.\n");
    int i;
    int sum=0;
    for(i=0; i<10; i++)
    {
        printf("Enter the %d number = ", i+1);
        scanf("%d", & array[i]);
    }
    for(i=0; i<10; i++)
    {
        printf("The %d number value is, %d\n", i+1, array[i]);
    }
    for(i=0; i<10; i++)
    {
        sum=sum+array[i];
    }
    printf("The summation of all the six values is, %d", sum);
    return 0;
}
