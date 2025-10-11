import sys

for line in sys.stdin:
    if line.strip():  # 빈 줄 무시
        parts = line.strip().split()
        for i in range(0, len(parts), 2):
            N = int(parts[i])
            S = int(parts[i + 1])
            x = S // (N + 1)
            print(x)
