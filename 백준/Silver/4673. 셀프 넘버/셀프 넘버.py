count = 0
self_num = []

def IsSelf(n):
    d = n + sum(int(digit) for digit in str(n))
    return d

generated = set()

while count <= 10000:
    generated.add(IsSelf(count))
    count += 1

count = 0
while count <= 10000:
    if count not in generated:
        self_num.append(count)
    count += 1

for x in self_num:
    print(x)
