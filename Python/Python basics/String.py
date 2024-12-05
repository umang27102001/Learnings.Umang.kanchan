str1 = "umaNg"
str2 = 'uMang'
str3 = """string is string is string"""
str4 = '''         string is string'''
it = ["1","2","3","4,5"]
def Print():
    print(str1.capitalize())
    print(str2.casefold())
    print(str3.count("is"))
    print("u" in str2)
    Slice()
    print(str3.upper())
    print(str3.lower())
    print(str3.capitalize())
    print(str3.endswith("string"))
    print(str3.find("is"))
    print(str3.replace("string","String"))
    print(str3.strip())
    print(str2.startswith("EEQ-Conquest"))
    print(f"My age is {20}")
    print(" ".join(it))
    print(str3.partition("is"))
    print(len(str4))

def Slice():
    print(str4[2:6])
    print(str4[::-1])
    
    
    