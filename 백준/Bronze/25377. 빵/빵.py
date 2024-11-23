import sys
from math import inf

def solution():
    input = sys.stdin.read
    data = input().splitlines()
    
    n = int(data[0])
    min_value = inf
    
    for i in range(1, n + 1):
        a, b = map(int, data[i].split())
        if a > b:
            continue
        min_value = min(min_value, b)
    
    print(-1 if min_value == inf else min_value)

if __name__ == "__main__":
    solution()
