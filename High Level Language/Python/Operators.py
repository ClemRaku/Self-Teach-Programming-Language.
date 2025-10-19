#OPERATORS
x = input("What's x? ")
y = input("What's y? ")

z = x +y 

#Terminal should show 'the two variables' instead of 'summation', due to it is being registered as a str, and not int.
print(z)

#TO make the values into int
z = int(x) + int(y)
#Now it'll print 'summation'
print(z)

#we can directly make the inputs int, by
a = int(input("What's a? "))
b = int(input("What's b? "))
c = a + b
print(c)

#Rounding up numbers.
i = float(input("What's i? "))
j = float(input("What's j? "))
k = round(i + j)
print(k)

#puting a comma besides the 3rd int
print(f"{k:,}")

#dividing, a number of digits. especially i & j
q = round(i / j, 2) #'2' is the decimal point.
print(q)

#we could do the exact same thing like
w = i / j
print(f"{w:.2f}")#formats the float into only two decimal point via, '.2f'      