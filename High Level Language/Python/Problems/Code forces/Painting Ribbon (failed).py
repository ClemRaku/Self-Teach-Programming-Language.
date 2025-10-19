def main():
    test_cases = int(input())
    result = []
    for _ in range(test_cases):
        n, m, k = map(int, input().split())

        result.append(painting_ribbon(n, m, k))

    for i in range(test_cases):
        print(result[i])

def painting_ribbon(num_of_parts, num_of_colors, Bob_chose_parts):
    div = num_of_parts / Bob_chose_parts
    if num_of_parts == 1 or num_of_colors == 1 or Bob_chose_parts >= num_of_parts or Bob_chose_parts == num_of_colors or div == 2:
        return "NO"
    else:
        return "YES"

main()