import sys
#this basically imports the name tag of the file
try:
    print("Hello, my name is", sys.argv[1])
except:
    print("Too few arguments")
#'try' & 'except' basically removes the error of the action of not providing any name of the tag of the file
#go to system name input 2