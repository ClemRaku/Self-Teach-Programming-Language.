students = {"Hermoine": "Gryffindor", "Harry": "Gryffindor", "Ron": "Gryffindor", "Draco": "Slytherin"}
print(students["Hermoine"])
print(students["Harry"])
print(students["Ron"])
print(students["Draco"])
print("\n")

#we could do the same could via for loop

for stu in students:
    print(students[stu])
print("\n")
#We could elaborate both of them via
for stu in students:
    print(stu, students[stu], sep=", ")

#Go to Dictionary 2 now.