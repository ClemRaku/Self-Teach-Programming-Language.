def main():
    string = input("Enter a name: ")
    string_list = list(string)
    distinct_characters = unshuffled_set(string_list)
    length_of_distinct_characters = len(distinct_characters)
    result = girl_or_boy(length_of_distinct_characters)
    print(result)
def unshuffled_set(words):
    unshuffled = []
    seen = set()#note
    for char in words:
        if char not in seen:
            seen.add(char)
            unshuffled.append(char)
    return unshuffled
def girl_or_boy(number):
    return "CHAT WITH HER!" if number%2==0 else "IGNORE HIM!"
main()