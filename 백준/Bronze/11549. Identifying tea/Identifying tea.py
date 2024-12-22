T = int(input())
n =0
answer=input().split()
A = int(answer[0])
B = int(answer[1])
C = int(answer[2])
D = int(answer[3])
E = int(answer[4])
result =[A, B, C, D, E]
for x in result:
    if x == T:
        n +=1
print(n)