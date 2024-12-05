x = 100

def fun():
    global x
    x+=1
    print(x)
    temp()
    
def temp():
    print(x)
