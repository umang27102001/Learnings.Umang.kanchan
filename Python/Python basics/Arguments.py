def fun(a,*args):
    print(a,args)

def kwFun(a,*args,**kwargs):
    print(a,args,kwargs)

fun(1,2,3,4,5,6,67,78)
kwFun(1,2,3,4,5,6,67,78,name="ronny",age=26)