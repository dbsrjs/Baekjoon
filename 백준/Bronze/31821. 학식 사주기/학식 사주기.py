# 메뉴의 개수 입력
n = int(input())

# 메뉴 가격을 저장하는 리스트
price = [0] * (n + 1)
for i in range(1, n + 1):
    price[i] = int(input())

# 총 내야 될 가격 계산
sum = 0
n = int(input())  # 새내기의 인원 수
for _ in range(n):
    index = int(input())  # 먹고 싶어하는 메뉴
    sum += price[index]

# 결과 출력
print(sum)
