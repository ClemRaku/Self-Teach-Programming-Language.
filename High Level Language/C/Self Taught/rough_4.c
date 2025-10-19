#include<stdio.h>

void knapsack(int n, float profits[], float weights[], float ratio[], float capacity){
    float remaining_weight, x[n], total_profit;
    int i, j;
    remaining_weight = capacity;
    for(i = 0; i<n; i++){
        x[i] = 0.0;
    }
    for(i = 0; i<n; i++){
        if(weights[i]<remaining_weight){
            x[i] = 1.0;
            total_profit = total_profit + profits[i];
        }
        else{
            break;
        }
    }
    if(i>n){
        x[i] = remaining_weight / weights[i];
        total_profit = total_profit + (x[i] * profits[i]);
    }
    printf("\n\nTotal profit is: .2%f", total_profit);
}

int main(){
    int num_of_objects;
    printf("Enter the amount of objects: ");
    scanf("%d", &num_of_objects);
    float profits[num_of_objects], weights[num_of_objects], ratio[num_of_objects];
    int i ,j;
    for(i = 0; i<num_of_objects; i++){
        printf("Enter Weights & Profits: ");
        scanf("%f %f", &weights[i], &profits[i]);
        ratio[i] = profits[i] / weights[i];
    }

    float limit_weight;
    printf("Enter the capacity: ");
    scanf("%f", &limit_weight);
    //swap
    int temp = 0;
    for(i = 0; i<num_of_objects; i++){
        for(j = i+1; j<num_of_objects; j++){
            //swap ratio
            temp = ratio[i];
            ratio[i] = ratio[j];
            ratio[j] = temp;
            //swap profits
            temp = profits[i];
            profits[i] = profits[j];
            profits[j] = temp;
            //swap weights
            temp = weights[i];
            weights[i] = weights[j];
            weights[j] = temp;
        }
    }

knapsack(num_of_objects, profits, weights, ratio, limit_weight);
    return 0;
}
