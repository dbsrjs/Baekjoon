colors = [
    "black", "brown", "red", "orange", "yellow",
    "green", "blue", "violet", "grey", "white"
]

color1 = input().strip()
color2 = input().strip()
color3 = input().strip()

first = colors.index(color1)
second = colors.index(color2)
multiplier = colors.index(color3)

result = (first * 10 + second) * (10 ** multiplier)
print(result)