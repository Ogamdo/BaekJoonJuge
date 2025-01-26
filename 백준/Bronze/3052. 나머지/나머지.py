nums = []
count = 0

while count < 10:
    num = int(input())
    nums.append(num % 42)
    count += 1

print(len(set(nums)))
