t = int(input())  # 테스트 케이스 개수
coins = [25, 10, 5, 1]  # Quarter, Dime, Nickel, Penny

for _ in range(t):
    cents = int(input())  # 센트 단위 입력
    result = []
    for c in coins:
        result.append(cents // c)
        cents %= c
    print(*result)