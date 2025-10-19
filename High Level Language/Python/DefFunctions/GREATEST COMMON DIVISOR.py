def main():
    a, b = map(int, input("Enter a, b: ").split())

def gcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

main()
