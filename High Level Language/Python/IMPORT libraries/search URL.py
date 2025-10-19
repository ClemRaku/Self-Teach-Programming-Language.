import json
import requests
import sys

if len(sys.argv) != 2:
    sys.exit()
#'get' basically uses the argument URL, to search something, and stores the JSON codes of it.
response = requests.get("https://itunes.apple.com/search?entity=song&limit=50&term=" + sys.argv[1])
print(json.dumps(response.json(), indent=2))
#'.json()' is the function that basically, prints all the json files on the terminal
#'dumps' is a function that makes the json texts in a much more readable way. 
#'indent' is a parameter that indents with each hierarchy
o = response.json()
for result in o["results"]:
    print(result["trackName"])