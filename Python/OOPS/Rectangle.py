class Rectangle:
    len=10
    def __init__(self,len,bred):
        self.len=len
        self.bred=bred
    def Area(self):
        return self.len
    
r1=Rectangle(10,20)
r2=Rectangle(30,40)

def Print():
    print(r2.Area())