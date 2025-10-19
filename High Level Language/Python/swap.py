#SWAP
a, b = map(int, input("Enter a, b: ").split())
print(f"Initial: {a}, {b}")
a, b = b, a
print(f"Finally: {a}, {b}")
