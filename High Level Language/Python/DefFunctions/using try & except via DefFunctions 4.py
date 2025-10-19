#check 'pass' first
def main():
    x = get_int("What's x? ")
    print(f"x is {x}")

def get_int(prompt):
    while True:
        try:
            return int(input(prompt))
        except ValueError:
            pass


# 'return', basically returns te value of x out of the 'get_int()' function
main()