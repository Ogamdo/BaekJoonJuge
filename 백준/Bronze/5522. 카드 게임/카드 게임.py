n = 5
sum =0
while(n>0):
    str =input()
    num = int(str)
    sum += num
    n -= 1
    if str=="":
        break
print(sum)