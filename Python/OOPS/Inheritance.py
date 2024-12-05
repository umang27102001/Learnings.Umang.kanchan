class Person:
    def __init__(self,name,age):
        self.name=name
        self.age=age
    def getName(self):
        return self.name

class Student(Person):
    def __init__(self,name,age,marks):
        Person.__init__(self,name,age)
        self.marks=marks
        
def Print():
    std = Student("um",0,90)
    print(std.getName())