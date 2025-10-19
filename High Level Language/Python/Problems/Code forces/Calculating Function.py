""" 
    def CalculatingFunction(n):
    fn = 0
    sub = True
    for i in range(1, n+1):
        if sub :
            fn = fn - i
            sub = False
        else:
            fn = fn + i           
            sub = True 
    return fn
user = int(input())
print(CalculatingFunction(user))
"""#The above code is very unoptimized. I'mma do one that's better. 
def CalculatingFunction(n):
    fn = 0
    if n%2 == 0:
        return n//2
    else:
        return -((n//2)+1)
user = int(input())
print(CalculatingFunction(user))

