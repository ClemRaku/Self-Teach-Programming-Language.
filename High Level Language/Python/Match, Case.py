name = input("What's your name? ")

match name:
    case "Harry" | "Hermoine" | "Ron": #this is same as saying, Harry or Hermoine or Ron
        print("Gryffindor")
    case "Draco":
        print("Slytherin")
    case _:
        print("Who?")