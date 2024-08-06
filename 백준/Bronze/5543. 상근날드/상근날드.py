burger1 = int(input())
burger2 = int(input())
burger3 = int(input())

Coka = int(input())
Sprite = int(input())

burgers = [burger1, burger2, burger3]
snacks = [Coka, Sprite]

burgers.sort()
snacks.sort()

print(burgers[0] + snacks[0] - 50)