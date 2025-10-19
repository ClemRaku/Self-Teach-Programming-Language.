def main():
    test_cases = int(input("Test Case: "))
    coins = []
    numbers = []
    for _ in range(test_cases):
        number_of_coins = int(input("Number of Coins: "))
        coin = mek_list(number_of_coins)
        while True:
            if len(coin)>1:
                flip_Alice(coin)
                coins.append(coin)
                flip_Bob(coin)
                coins.append(coin)
            else:
                break
    print(coins)

def mek_list(n):
    UUDD = input("ENTER: ")
    return list(UUDD) #list


def flip_Alice(c):
    if len(c) <= 2:
        delete_first_element(c)
        return c
    else:
        c[-1] = "D" if c[-1] == "U" else "U"
        c[1] = "D" if c[1] == "U" else "D"
        delete_first_element(c)
    return c
def flip_Bob(b):
    if len(b) <= 2:
        delete_first_element(b)
        return b
    else:
        last_element = len(b) - 1
        b[0] = "D" if b[0] == "U" else "U"
        b[last_element-1] = "D" if b[last_element-1] == "U" else "U"
        delete_last_element(b)
    return b

def delete_first_element(arr):
    if len(arr)>0:
        del arr[0]
    return arr

def delete_last_element(last):
    if len(last)>0:
        del last[len(last) - 1]
    return last

main()
