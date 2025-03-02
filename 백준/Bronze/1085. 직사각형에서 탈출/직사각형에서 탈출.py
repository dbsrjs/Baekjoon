x, y, w, h = map(int, input().split())

x_min = min(x, w - x)  # x축 최소 거리
y_min = min(y, h - y)  # y축 최소 거리

print(min(x_min, y_min))  # 최소값 출력
