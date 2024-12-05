tp =  1,2,3,4,5
tp = (1,)
tp = tuple(list((1,2,3,4,5,6,7)))

tp = tuple([x if x!=1 else 0 for x in tp])
ls = list(tp)
ls.pop(0)
tp = tuple(ls)

# unpack a tuple
(a,*b,c) = (1,2,3,4,4)

tp = tp*3
def PrintTuple():
    print(tp)
    print(a,b,c)