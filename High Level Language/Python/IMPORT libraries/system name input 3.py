import sys
#check for errors
if len(sys.argv) < 2:
    sys.exit("Too few arguments")
elif len(sys.argv) > 2:
    sys.exit("Too many arguments")
#print name tags
print("Hello, my name is", sys.argv[1])

#'sys.exit' immediately breaks out of the code after the statement is ran.