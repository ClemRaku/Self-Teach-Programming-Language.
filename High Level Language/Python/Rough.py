w = input().strip()
w_mirrored = ''
w = w.upper()
if len(w) > 1:
    for char in w:
        w_mirrored = char + w_mirrored
    if w_mirrored == w:
        print("YES")
    else:
        print("NO")
else:
    print("NO")
