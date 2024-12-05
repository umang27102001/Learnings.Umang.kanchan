class Vehicle:
    def Move(self):
        print("Move!")

class Car(Vehicle):
    pass

class Boat(Vehicle):
    def Move(self):
        print("sail")
        
class Plane(Vehicle):
    def Move(self):
        print("Fly")
        
def Print():
    v1 = Car()
    v2 = Boat()
    v3 = Plane()
    v1.Move()
    v2.Move()
    v3.Move()