n = int(input())
n_list = []
for i in range(1,n+1):
    n_list.append(i)
s = input()
result = []

for i in range(n-1):
    if s[i] == '<':
        n_list.sort()
        result.append(n_list[i])
        result.append(n_list[i+1])
    elif s[i] == '>':
        n_list.sort(reverse=True)
        result.append(n_list[i])
        result.append(n_list[i+1])
for i in result:
    print(i)