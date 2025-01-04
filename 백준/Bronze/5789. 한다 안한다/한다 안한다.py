N = int(input())

while N>0:
    testCase = input()
    while len(testCase)>2:
        testCase= testCase[1:-1]
    if len(testCase)==2 and testCase[0]==testCase[1]:
        print("Do-it")
    elif len(testCase)==2 and testCase[0]!=testCase[1]:
        print("Do-it-Not")
    N-=1 
