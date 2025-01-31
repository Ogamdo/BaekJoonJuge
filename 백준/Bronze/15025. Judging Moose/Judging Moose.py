l, r = map(int, input().split())

if l == r and l + r != 0:
    print(f"Even {l + r}")
elif l != r and l + r != 0:
    if l > r:
        print(f"Odd {2 * l}")
    else:
        print(f"Odd {2 * r}")
elif r + l == 0:
    print("Not a moose")
