# 문자열 개수 입력
T = int(input())

# 문자열 리스트 입력 받기
arr = [input().strip() for _ in range(T)]

result = ""

# 첫 번째 문자열의 길이를 기준으로 반복
for i in range(len(arr[0])):
    first_char = arr[0][i]  # 첫 번째 문자열의 i번째 문자
    is_same = True

    for j in range(1, T):
        if arr[j][i] != first_char:
            is_same = False
            result += "?"
            break

    if is_same:
        result += first_char  # 같은 문자면 결과에 추가

print(result)
