a, b, c, d = map(int, input().split())


team1 = min(a, b) + max(c, d)
team2 = max(a, b) + min(c, d)

if(team1 >= team2):
    print(team1 - team2)
else:
    print(team2 - team1)