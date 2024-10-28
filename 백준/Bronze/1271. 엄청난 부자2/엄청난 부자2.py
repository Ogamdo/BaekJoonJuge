firstLine = input()
values =firstLine.split()
values_int_list = list(map(int, values))
n = values_int_list[0]
m = values_int_list[1]
quo = n//m
rim = n%m
print(quo)
print(rim)