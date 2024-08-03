a, b, c = map(int, input().split())
d = int(input())

hour = a + d // 3600
d %= 3600

minute = b + d // 60
d %= 60

second = c + d

if second >= 60:
    minute += second // 60
    second %= 60

if minute >= 60:
    hour += minute // 60
    minute %= 60

hour %= 24

print(hour, minute, second)