def main():
    print_column(3)
    print_row(4)
    print_square(3)
def print_column(height):
    for _ in range(height):
        print("#")
        
def print_row(width):
    print("?"*width)

def print_square(size):
    #For each row
    for i in range(size):
        #For each column
        for j in range(size):
            print("@", end="")
        print()#print stops the new line made by the print in the 17th line
main()