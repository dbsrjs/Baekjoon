a=int(input())
for i in range(1,a):
    star = "*"*i
    print(star.rjust(a))
for i in range(a,0,-1):
    star="*"*i
    print(star.rjust(a))