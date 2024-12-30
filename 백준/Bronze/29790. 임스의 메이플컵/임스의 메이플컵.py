N, U, L = map(int, input().split())

sign = 0

if N >= 1000 : 
    sign = 1
else : 
    print('Bad')


if sign == 1 and (U >= 8000 or L >= 260) :
    sign += 1

if sign == 1 : 
    print('Good')
elif sign == 2 : 
    print('Very Good')