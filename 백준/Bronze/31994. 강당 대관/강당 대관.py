max_seminar = ""
max_count = 0

for _ in range(7):
    seminar, count = input().split()
    count = int(count)

    if max_count < count:
        max_count = count
        max_seminar = seminar

print(max_seminar)
