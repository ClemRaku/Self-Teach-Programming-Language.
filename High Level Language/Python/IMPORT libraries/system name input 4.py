import sys

if len(sys.argv) < 2:
    sys.exit("Too few arguments")
#'1:' basically deletes the first, 0th position element which was the name of the file itself
for arg in sys.argv[1:]:
    print("Hello, my name is", arg)
