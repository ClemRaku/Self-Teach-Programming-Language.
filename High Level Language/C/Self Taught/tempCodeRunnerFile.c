#include <stdio.h>

void knapsack(float profit[], float weight[], float ratio[], float capacity, int n) {
    float x[n];
    float remaining_capacity = capacity;
    float total_profit = 0;
    int i;

    // Initialize all items as not included
    for(i = 0; i < n; i++) {
        x[i] = 0.0;
    }

    // Include items with maximum ratio until capacity is full
    for(i = 0; i < n; i++) {
        if(weight[i] <= remaining_capacity) {
            x[i] = 1.0;
            total_profit += profit[i];
            remaining_capacity -= weight[i];
        } else {
            break;
        }
    }

    // Include the fraction of the last item if the knapsack is not full
    if(i < n) {
        x[i] = remaining_capacity / weight[i];
        total_profit += x[i] * profit[i];
    }

    printf("\n\nMax Profit: %0.2f\n", total_profit);
}

int main() {
    int objects, i, j;
    printf("Enter the number of objects: ");
    scanf("%d", &objects);

    float profits[objects], weight[objects], ratio[objects], capacity;

    for(i = 0; i < objects; i++) {
        printf("Enter Weight and Profit of object %d: ", i + 1);
        scanf("%f %f", &weight[i], &profits[i]);
        if(weight[i] != 0) {
            ratio[i] = profits[i] / weight[i];
        } else {
            ratio[i] = 0; // Handle case if weight is zero
        }
    }

    printf("Enter the capacity of the Knapsack: ");
    scanf("%d", &capacity);

    // Sort items based on their profit-to-weight ratio in descending order
    for(i = 0; i < objects - 1; i++) {
        for(j = i + 1; j < objects; j++) {
            if(ratio[i] < ratio[j]) {
                // Swap ratios
                float temp_ratio = ratio[i];
                ratio[i] = ratio[j];
                ratio[j] = temp_ratio;

                // Swap profits
                float temp_profit = profits[i];
                profits[i] = profits[j];
                profits[j] = temp_profit;

                // Swap weights
                float temp_weight = weight[i];
                weight[i] = weight[j];
                weight[j] = temp_weight;
            }
        }
    }

    knapsack(profits, weight, ratio, capacity, objects);

    return 0;
}
