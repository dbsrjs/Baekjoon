x = int(input())
y = int(input())

# + + : 1
# - + : 2
# - - : 3
# + - : 4

if(x > 1 and y > 1):
    print(1)
elif(x < 1 and y > 1):
    print(2)
elif(x < 1 and y < 1):
    print(3)
elif(x > 1 and y < 1):
    print(4)