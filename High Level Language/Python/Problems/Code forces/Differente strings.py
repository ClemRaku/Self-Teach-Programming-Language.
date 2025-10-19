import random

def main():
    test_cases = int(input())
    No_yes = []
    final_list = []
    for _ in range(test_cases):
        string = input()
        check = 0
        for i in range(len(string)):
            if string[0] == string[i]:
                check += 1
        if len(string) == check:
            No_yes.append("1")
        else:
            No_yes.append("0")
            random_word = randomizer_words(string)
            final = remove_unnecesarry(random_word)
            final_list.append(final)
    final_list_index = 0
    for i in range(test_cases):
        if No_yes[i] == "1":
            print("NO")
        else:
            print("YES")
            print(final_list[final_list_index])
            final_list_index += 1

def randomizer_words(letter):
    list_of_letters = list(letter)
    while True:
        shuffled = list_of_letters[:] #note this
        random.shuffle(shuffled) #note this as well
        if list_of_letters == shuffled:
            continue
        else:
            break
    return shuffled

def remove_unnecesarry(remove):
    return "".join(remove)
main()