n = int(input())
divisbles = []
for i in range(1, n+1):
    if n % i == 0:
        divisbles.append(i)
for d in divisbles:
    print(d)