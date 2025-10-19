def main():    
    numbers_with_plus = input()
    list_of_numbers = remove_plus(numbers_with_plus)
    sorted_numbers = sorted(list_of_numbers)#note this
    add_plus_sorted = plus(sorted_numbers)
    print(add_plus_sorted)
def remove_plus(num_plus):
    num = []
    for i in num_plus:
        if i != "+":
            num.append(i)
    return num

def plus(number):
    return "+".join(number)
main()
