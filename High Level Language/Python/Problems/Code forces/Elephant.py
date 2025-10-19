def main():
    x = int(input("Enter x: "))
    if x <= 5:
        print("1")
    else:
        result = num_of_steps(x)
        print(result)
def num_of_steps(steps):
    count = 0
    while steps > 0:
        if steps >= 5:
            steps -= 5
            count += 1
        elif steps >= 4:
            steps -= 4
            count += 1
        elif steps >=3:
            steps -= 3
            count += 1
        elif steps >=2:
            steps -= 2
            count += 1
        elif steps >=1:
            steps -= 1
            count += 1
    return count
main()