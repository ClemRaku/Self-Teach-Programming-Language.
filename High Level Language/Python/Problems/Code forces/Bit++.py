def main():
    number_lines = int(input("Number of lines: "))
    list_of_operations = []  # Fixed variable naming consistency
    for _ in range(number_lines):
        operations = input("OPERATIONS: ")
        list_of_operations.append(operations)
    result = Bit_or_minus(list_of_operations)
    print(result)
def Bit_or_minus(signs):
    plus = 0
    plus_or_minus = 0
    minus = 0
    for sign in signs:
        for char in sign:
            if char == "+":
                plus_or_minus += 1
                break
            elif char == "-":
                plus_or_minus -= 1
                break
    return plus_or_minus
main()
