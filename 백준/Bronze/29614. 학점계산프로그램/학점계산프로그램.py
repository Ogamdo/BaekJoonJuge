S=input()
n=0
sum=0
for x in S:
    if x != "+":
        if x=='A':
            n +=1
            sum +=4
        elif x=='B':
            n +=1
            sum +=3
        elif x=='C':
            n+=1
            sum +=2
        elif x=='D':
            n +=1
            sum +=1
        elif x=='F':
            n +=1
            
    else:
        sum +=0.5
print(sum/n)