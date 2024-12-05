def sum(a):
    ans = 0
    for item in a:
        ans+=item
    return ans

fun = lambda a,b : a==b

def Print():
    print(sum([1,2,3,4,5,6,7]))
    print(fun(5,8))