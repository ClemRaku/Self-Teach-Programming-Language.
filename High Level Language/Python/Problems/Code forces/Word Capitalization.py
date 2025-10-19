string = input("Enter a word: ")
after_first_char = string[1:]
letter_to_capitalize = string[0].upper()
final = letter_to_capitalize + after_first_char
print(final)
