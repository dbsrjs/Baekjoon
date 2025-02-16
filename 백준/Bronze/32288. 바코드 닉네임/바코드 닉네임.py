len_ = int(input())
name = input()
rs = ""

for c in name:
    if c.isupper():
        rs += c.lower()
    else:
        rs += c.upper()

print(rs)
