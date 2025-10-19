def main():
    test_cases = int(input("Enter Test Cases: "))
    result = []
    for _ in range(test_cases):
        a, b, c = map(int, input("a, b, c = ").split())
        result.append(odd_one_out(a, b, c))
    for i in range(test_cases):
        print(result[i])
def odd_one_out(first_num, second_num, third_num):
    if first_num == second_num:
        return third_num
    elif first_num == third_num:
        return second_num
    else:
        return first_num
main()