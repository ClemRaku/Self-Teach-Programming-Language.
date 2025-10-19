#include<stdio.h>

void knapsack(int n, float profit[], float weight[], float ratio[], float capacity){
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
            total_profit = profit[i] + total_profit;
            remaining_capacity = remaining_capacity - weight[i];
        }
        else{
            break;
        }
    }
    if(i<n){
        x[i] = remaining_capacity / weight[i];
        total_profit = total_profit + (x[i] * profit[i]);
    }
    printf("\n\n\nTotal Profit is: %.2f", total_profit);
}


int main(){
    int num_of_objects;
    printf("Enter the amount of objects: ");
    float capacity;
    float profits[num_of_objects], weights[num_of_objects], ratio[num_of_objects];
    int i, j; //for loops
    for(i = 0; i<num_of_objects; i++){
        printf("Enter weights & profits with a whitespace: ");
        scanf("%f %f", &weights, &profits);
    }
    printf("Capacity: ");
    scanf("%f", &capacity);
    //ratio
    for(i = 0; i<num_of_objects; i++){
        ratio[i] = profits[i] / weights[i];
    }
    //swap
    int temp = 0;
    for(i = 0; i<num_of_objects; i++){
        for(j = i+1; j<num_of_objects; j++){
            if(ratio[i] < ratio[j]){
                //ratio swap
                temp = ratio[i];
                ratio[i] = ratio[j];
                ratio[j] = temp;
                //profit swap
                temp = profits[i];
                profits[i] = profits[j];
                profits[j] = temp;
                //weight swap
                temp = weights[i];
                weights[i] = weights[j];
                weights[j] = temp;
            }
            else{
                continue;
            }
        }
    }
knapsack(num_of_objects, profits, weights, ratio, capacity);

    return 0;
}
