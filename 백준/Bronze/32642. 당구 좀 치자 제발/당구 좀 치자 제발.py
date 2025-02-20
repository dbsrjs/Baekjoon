N = int(input())
weather = list(map(int, input().split()))
anger = [0] * N  
status = 0 

for i in range(N):
    if weather[i] == 1:
        status += 1
    elif weather[i] == 0:
        status -= 1

    anger[i] = status

print(sum(anger))