count = 0

for i in range(8):  # 8줄 입력
    line = input().strip()  # 한 줄 입력받기
    for j in range(8):  # 각 문자 확인
        if (i + j) % 2 == 0 and line[j] == 'F':  # 하얀 칸 + 말 있음
            count += 1

print(count)