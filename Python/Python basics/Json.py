import json



def Print():
    x = '{ "name":"John", "age":30, "city":"New York"}'
    y = json.loads(x)
    dict = {
  "name": "John",
  "age": 30,
  "city": "New York"
}
    
    output = json.dumps(dict)
    print(output)
    print(json.dumps(["a","b","c",4]))
    print(json.dumps(True))