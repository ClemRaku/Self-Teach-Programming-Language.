##Input & Output
name = input("What's your name? ")

#Output/print
print("1. Hello", name)

#or can be written like this
print("2. Hello " + name)

#or can be written as
print("3. Hello ", end="")
print(name)

#or can be written as
print("4. Hello" , name, sep=" ")

# end = "", sep="", these are known as parameters. 
# within the "", are the arguements.



## 'f' formates the arguement inside the '{}'
print(f"5. Hello {name}")  #This has a problem, it counts white spaces as well

##To remove the white spaces. We can.
name = name.strip()
print(f"6. Hello {name}")  

#Capitilize the first character of the str 'name'
name = name.capitalize() #This only capitilizes the first character of the first string
print("7. Hello", name)

#Capitilize the first character of each string. 
name = name.title()
print("8. Hello", name)

## It can also be written as, name.strip().title()
## can also be written as, print(f"5. Hello {name}").strip().title.()

#Spliting user's name into first & last name.
first, last = name.split(" ")
print(f"9. Hello {first}")#prints the first name only.
