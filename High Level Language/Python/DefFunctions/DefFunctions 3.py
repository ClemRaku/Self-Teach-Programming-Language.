#continuation of the DefFunction 2
#Code in the DefFunction 1 & 2 can be written as
def main():
    name = input("What's your name? ")
    hello(name)

def hello(to = "User"):
    print("Hello,", to)

main()