k, a, b, v = map(int, input().split())
num_of_BOZ = 1
while a > 0:
    sections = b + 1
    if (sections > k):
        nuts_per_boz = k * v
        b_used = k - 1
        b -= b_used
        a -= nuts_per_boz
        if (a > 0):
            num_of_BOZ += 1
    else:
        nuts_per_boz = sections * v
        b_used = sections - 1
        b -= b_used
        a -= nuts_per_boz
        if (a > 0):
            num_of_BOZ += 1        
print(num_of_BOZ)