#check BOOLEAN 2 first, then see this
def main():
    x = int(input("x = "))
    if is_even(x):
        print("EVEN")
    else:
        print("ODD")
def is_even(n):
    #another variation compared to BOOLEAN 1 & 2
    return n % 2 == 0
    #this is the most optimized code
main()
