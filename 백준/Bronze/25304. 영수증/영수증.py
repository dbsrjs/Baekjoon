all = int(input())  #영수증 가격
cnt = int(input()) #구매 개수

money = 0

for i in range(cnt):
    a, b = map(int, input().split())
    money += a * b

if all == money:
    print("Yes")
else:
    print("No")