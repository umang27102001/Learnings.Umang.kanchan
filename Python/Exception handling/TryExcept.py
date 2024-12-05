try:
    print([1,2,3].index(6))
except ValueError as ve:
    print("ValueError occured",ve)
except Exception as ex:
    print("Exception occured!", ex)
else:
    print("Exception did not occur")
finally:
    print("Finally")
    
try:
  try:
    raise ValueError("Hello I am value error")
  except ValueError as ve:
    print("Error occured",ve)
  finally:
    try:
        raise Exception("Exception raised")
    except Exception as ex:
        print("Hello", ex)
except:
  print("Something went wrong when opening the file")
else:
    print("Else")