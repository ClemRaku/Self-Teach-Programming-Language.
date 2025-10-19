#check using try & except via DefFunctions files first
def main():
    x = get_int()
    print(f"x is {x}")

def get_int():
    while True:
        try:
            return int(input("What's x? "))
        except ValueError:
            pass
#pass is similar to 'continue' but it just doesn't do anything
# 'return', basically returns te value of x out of the 'get_int()' function
main()