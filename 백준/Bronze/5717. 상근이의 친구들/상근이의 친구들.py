going = True
frs=[]

while going:
    M, F =map(int, input().split())
    if M==0 and F==0:
        break
    frs.append(M+F)

for x in frs:
    print(x)
