students = ["Hermoine", "Harry", "Ron"]

print(students[0])
print(students[1])
print(students[2])
print("\n")

#the above code could be written as
for pupils in students:
    print(pupils)
print("\n")

#len() functions is used to find the length of a string.
#length of the 'students' string is 3.
for i in range(len(students)):
    print(students[i])