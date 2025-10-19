try:
    x = int(input("What's x? "))
    print(f"x is {x}")
except ValueError:
    print("x is not an integer")
#This basically states when an error occurs.
else:
    print(f"this line is also executed due to 'try' also being executed")
#'else' works due to the fact that 'try' is working
#go to Error Statement 2 