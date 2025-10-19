import random

#'randint()', basically chooses random integers from the range arguments give inside the parenthesis.
number = random.randint(1, 10)
print(f"Random number is {number}")
print("\n")
cards = ["jack", "queen", "king"]
#'shuffle()' basically shuffles the argument
for i in cards:
    print(i)