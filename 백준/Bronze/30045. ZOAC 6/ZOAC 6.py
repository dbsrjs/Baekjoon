index = int(input())

cnt = 0

for _ in range(index):
    str_input = input()
    if "01" in str_input or "OI" in str_input:
        cnt += 1

print(cnt)
