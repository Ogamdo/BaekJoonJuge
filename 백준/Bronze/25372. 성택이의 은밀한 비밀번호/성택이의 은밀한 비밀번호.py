N = input()  
n = int(N)  

while n > 0:
    str = input()  
    if len(str) > 5 and len(str) < 10:
        print("yes")
    else:
        print("no")
    n -= 1  
  
