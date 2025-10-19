#check BOOLEAN 1 first, then see this
def main():
    x = int(input("x = "))
    if is_even(x):
        print("EVEN")
    else:
        print("ODD")
def is_even(n):
    #another variation compared to BOOLEAN 1
    return True if n%2 == 0 else False

main()
#Check BOOLEAN 3 now