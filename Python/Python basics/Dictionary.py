a={
    "Name":"Umang Kanchan",
    "Role":"Software engineering Intern",
    "Manager":"Mohit Kumar",
    "Company":"automotiveMastermind Rocks"
}

a["Review"] = "Good"
del a["Role"]

newDict = dict({("a",1),("b",2),("c",3),("d",4),("e",5),("f",6)})

a.update(newDict)
def PrintDict():
    print(a["Name"])
    print(a["Review"])
    Iterate()
    print(a.keys())
    print(a.values())
    print(a.items())
    
def Iterate():
    print("{")
    for key,value in newDict.items():
        print(f"{key} : {value}")
    print("}")