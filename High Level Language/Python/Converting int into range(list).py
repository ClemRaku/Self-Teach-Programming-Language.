x = int(input("X: "))
xlist = [i for i in range(x)]
print("First method,", xlist)

#or

xlist2 = []
for j in range(x):
    xlist2.append(j)
print("Second methond,", xlist2)

xlist3 = list(range(x))
print("Third method,", xlist3)

#or to make a list of strings in a line
string = input("Enter a sentence with words: ")
string_list_space = string.split()
string_list = list(string_list_space)
print("The list of strings is:", string_list)