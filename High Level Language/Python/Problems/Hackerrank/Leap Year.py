#leap year
def main():
    year = int(input("YEAR: "))
    leap = leap_year(year)
    print(leap)
def leap_year(y):
    if y % 400 == 0:
        return "True"
    elif y % 100 == 0:
        return "True"
    elif y % 4 == 0:
        return "True"
    else:
        return "False"
main()