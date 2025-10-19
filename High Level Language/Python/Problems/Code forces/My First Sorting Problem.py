def main():
    test_cases = int(input())
    result_list = []
    for _ in range(test_cases):
        x, y = map(int, input().split())
        result = compare(x, y)
        result_list.append(result)
    for i in range(test_cases):
        print(result_list[i])
def compare(a, b):
    if a > b:
        return f"{b} {a}"
    elif a < b:
        return f"{a} {b}"
    else:
        return f"{a} {b}"
main()