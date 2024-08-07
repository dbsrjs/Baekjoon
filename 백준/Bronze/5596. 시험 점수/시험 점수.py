min_input = input().split()
man_input = input().split()

min_result = sum(map(int, min_input))
man_result = sum(map(int, man_input))

if min_result >= man_result:
    print(min_result)
else:
    print(man_result)
