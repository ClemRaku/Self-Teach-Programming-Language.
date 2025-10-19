def main():
    x = int(input("What's x? "))
    print("x squared is", square(x))

def square(n):
    return n * n

main()

#the same thing can be written as python functions such as
# n**2     '2' is the power and 'n' is the base
# pow(n, 2)   '2' is the power and 'n' is the base