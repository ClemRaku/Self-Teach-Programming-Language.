#include <stdio.h>
void knapsack(float profit[], float weight[], float ratio[], float capacity, int n){
    float x[n];
    float remaining_capacity = capacity;
    float total_profit = 0;
    int i, j; //for loops
    for(i = 0; i<n; i++){
        x[i] = 0.0;
    }
    for(i = 0; i<n; i++){
        if(remaining_capacity>=weight[i]){
            x[i] = 1.0;
            total_profit = total_profit + profit[i];
            remaining_capacity = remaining_capacity - weight[i];
        }   
        else{
            break;
        }
    }
    if(i<n){
        x[i] = remaining_capacity/weight[i];
        total_profit = total_profit + (x[i] * profit[i]);
    }
    printf("\n\n Max Profit: %0.2f", total_profit);

}





int main()
{
    int objects, i, j;
    printf("Enter the number of objects: ");
    scanf("%d", &objects);
    float profits[objects], weight[objects], ratio[objects];
    float capacity;
    for (i = 0; i < objects; i++)
    {
        printf("Enter Weights & Profits with a white space in between: ");
        scanf("%f %f", &weight[i], &profits[i]);
    }
    printf("Enter the capacity of the Knapsack: ");
    scanf("%f", &capacity);
    for (j = 0; j < objects; j++)
    {
        ratio[j] = profits[j] / weight[j];
    }
    // sort
    int temp = 0;
    //swap start
    for (i = 0; i < objects; i++)
    {
        for(j = i+1; j<objects; j++){
            if(ratio[i]<ratio[j]){
                //swap ratio
                temp = ratio[i];
                ratio[i] = ratio[j];
                ratio[j] = temp;

                //swap profits
                temp = profits[i];
                profits[i] = profits[j];
                profits[j] = temp;

                //swap weights
                temp = weight[i];
                weight[i] = weight[j];
                weight[j] = temp;
            }
            else{
                continue;
            }
        }
    }
    knapsack(profits, weight, ratio, capacity, objects);
    return 0;
}
