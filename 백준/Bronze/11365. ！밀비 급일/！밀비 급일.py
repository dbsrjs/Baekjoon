while True:
    password = input()
    if password == "END": # 암호가 END 일 때 종료
        break
    else:
        password = password[::-1] # 모든 문자열을 뒤집는다.
        print(password)