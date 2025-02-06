T = int(input())

for _ in range(T):
    a, b = map(int, input().split())

    # a^b의 마지막 자리 숫자 계산 (Python의 pow 함수를 활용)
    r = pow(a, b, 10)

    # 마지막 자리가 0이면 10으로 변경
    print(10 if r == 0 else r)
