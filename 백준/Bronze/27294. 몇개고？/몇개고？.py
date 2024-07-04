T, S = map(int, input().split())    # t : 시간, s : 술 우뮤

if S == 1 or not(T >=12 and T <= 16):
    print(280)
else:
    print(320)