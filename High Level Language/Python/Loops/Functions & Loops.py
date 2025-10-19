def main():
    number = get_number()
    meow(number)

def get_number():
    while True:
        n = int(input("X = "))
        if n > 0:
            return n# 'return' returns a value from a defined function

def meow(n):
    for i in range(n):
        print("Meow")
main()