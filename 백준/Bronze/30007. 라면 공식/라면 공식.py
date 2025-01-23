N = int(input())
water_list = []

while N > 0:
    a, b, x = map(int, input().split())
    w = a * x - a + b
    water_list.append(w)
    N -= 1

for w in water_list:
    print(w)
