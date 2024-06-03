# 사용자로부터 N과 X를 입력받음
N, X = map(int, input().split())

# N개의 정수로 구성된 배열을 입력받음
arr = list(map(int, input().split()))

# X보다 작은 모든 수를 출력
for num in arr:
    if num < X:
        print(num, end=' ')
