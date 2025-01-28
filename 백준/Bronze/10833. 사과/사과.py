N = int(input())
sum=0

while N>0:
    nums= list(map(int, input().split()))
    q = nums[1]//nums[0] #몫
    r = nums[1] %nums[0] #나머지
    sum = sum+r
    N -=1

print(sum)