st = set(["umang","umang","tarun","sachit"])

st.add("kamal")
st.add("shalu")
st.remove("kamal")
newSet = set([1,2,3,4,5])
set2 = {"umang","tarun"}
st.update({6,0},["oppo"],("popco",))
def PrintSet():
    print(st)
    print(st.union([1,2,3,4],("kanchan","dipak"),{"varun",90}))
    print(st | newSet)
    print(st.intersection(set2))
    print(st & set(["umang"]))
    print(st.issubset(st))
    print(len(st))
    Iterate()

def Iterate():
    for x in st:
        print(x,end=" ")