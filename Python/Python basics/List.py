ls = [1,2,3,4,5]

# Add to list
ls.append("umang")
ls.insert(3,9)
ls.extend(("tarun","shalu","kamal","vinod"))

# Remove from the list
ls.remove(2)
ls.pop(2)
del ls[0]

# Iterate over a list
def PrintList():
    for item in ls:
        print(item,end=" ")
    print("\n")
    for index in range(len(newList)):
        print(newList[index],end=" ")
    print("\n")
    for index in range(len(copied)):
        print(copied[index],end=" ")
    print("\n")

# List compression
ls = ["banana", "Orange", "Kiwi", "cherry"]
newList = [x if x!="banana" else "orange" for x in ls]

# sort list.
ls.sort(key = str.lower)

# List copy
copied = ls.copy()
l2 =ls # l2 and ls point to same object


def Print():
    PrintList()