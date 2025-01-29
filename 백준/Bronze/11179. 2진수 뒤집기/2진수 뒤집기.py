N = int(input())  
biN = bin(N)[2:] 
reverse_biN = biN[::-1]  
reverse_biN = int(reverse_biN, 2)  

print(reverse_biN)  
