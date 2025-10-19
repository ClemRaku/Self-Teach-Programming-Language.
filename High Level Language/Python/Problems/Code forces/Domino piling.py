def main():
    m, n = map(int, input().split())
    dm = 2
    dn = 1
    area_of_dmdn = 2
    result = fit(area_of_dmdn, m, n)
    print(result)
def fit(area, height, width):
    area_of_height_width = height * width
    return int(area_of_height_width / area) if  area_of_height_width >= area else 0
main()
