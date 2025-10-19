#or can be written like this#we can simplify the previous code via
def main():
    x = get_int()
    print(f"x is {x}")

def get_int():
    while True:
        try:
            return int(input("What's x? "))
        except ValueError:
            print("x is not an integer")

# 'return', basically returns te value of x out of the 'get_int()' function
main()