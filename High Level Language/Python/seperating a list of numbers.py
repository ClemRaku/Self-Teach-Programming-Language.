n_and_k = input("Enter the numbers separated by a space: ")
n, k = n_and_k.split()
print(f"{n}, and {k}")

#if you want the values of 'n' & 'k' variables to be integer or other data type, you can use the map function
a_and_b = input("Enter the numbers again: ")
a, b = map(int, a_and_b.split())
print(f"{a}, and {b}")