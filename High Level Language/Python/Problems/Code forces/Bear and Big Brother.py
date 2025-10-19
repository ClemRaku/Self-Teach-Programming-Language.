def main():
    a, b = map(int, input().split())
    result = limak_weight_larger_than_bob(a, b)
    print(result)

def limak_weight_larger_than_bob(limak, bob):
    if limak <= bob:
        year = 0
        while limak <= bob:
            limak = limak * 3
            bob = bob * 2
            year += 1
        return year

main()