def main():
    string_of_words = input()
    list_of_words = string_of_words.split()
    word_reverse = reverse(list_of_words)
    final = no_brackets_comma(word_reverse)
    print(final)

def reverse(word):
    last_element = len(word) - 1
    rev = []
    for _ in range(len(word)):
        rev.append(word[last_element])
        last_element-=1
    return rev
def no_brackets_comma(arr):
    return " ".join(arr) #note this
main()