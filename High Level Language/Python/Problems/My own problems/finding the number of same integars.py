def main():
    test_cases = int(input())
    all_result = []
    for _ in range(test_cases):
        n_problems = int(input())
        list1problem = list_of_problems(n_problems)
        list2problem = list_of_problems(n_problems)
        result = compare(list1problem, list2problem)
        all_result.append(result)
    print_all_results(all_result)

def list_of_problems(x):
    a = input()
    return list(map(int, a.split()))

def compare(a, b):
    count = 0
    a_plus_b = a + b #note this
    element_dict = {}
    for element in a_plus_b:
        if element in element_dict:
            element_dict[element] += 1
        else:
            element_dict[element] = 1
    for values in element_dict.values():#Note this too
        if values > 1:
            count += 1
        else:
            continue
    return count

def print_all_results(p):
    for i in range(len(p)):
        print(p[i])
main()