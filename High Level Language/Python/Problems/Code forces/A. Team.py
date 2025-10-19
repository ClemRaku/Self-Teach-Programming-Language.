#'n' number of 3 integers, 1 or 0, assuming on random
def main():
    n = int(input("N: "))
    solved = only2(n)
    print(solved)
def only2(number_of_problems):
    solved = 0
    for _ in range(number_of_problems):
        first, second, third = map(int, input("ENTER: ").split())#note this
        if first + second + third >= 2:
            solved += 1
    return solved
main()