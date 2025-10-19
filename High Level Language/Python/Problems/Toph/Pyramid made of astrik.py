def main():
    number_of_lines_of_asterisk = int(input("Number of Asterisk: "))
    if number_of_lines_of_asterisk == 1:
        print("*")
    else:
        n_astrik = number_of_astrik(number_of_lines_of_asterisk)
        
        print(n_astrik)

def number_of_astrik(num):
    total = 0
    for _ in range(num):
        total += num 
        num -= 1
    return total
main()