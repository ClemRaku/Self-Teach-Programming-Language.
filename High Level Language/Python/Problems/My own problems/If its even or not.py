def main():
    weight = int(input())
    result = even_or_odd(weight)
    print(result)
def even_or_odd(w):
    return "YES" if w%2==0 else "NO"
main()
