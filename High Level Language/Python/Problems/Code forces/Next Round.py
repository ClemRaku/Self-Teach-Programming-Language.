def main():
    nth, kth = map(int, input().split())
    scores = list(map(int, input().split()))
    amount_of_pass = who_can_pass(scores, kth)
    print(amount_of_pass)

def who_can_pass(marks, fixed):
    passed = 0
    for i in range(len(marks)):
        if marks[i] >= marks[fixed-1] and marks[i] > 0:
            passed += 1
    return passed
main()