import codecs
import base64
f = open('.\OnionOriginal.txt')
data = f.read().encode('utf8')
while True:
    mode = input("input 1:'base64' or 2:'uu': ")
    if mode in {'1', 'base64'}:
        data = base64.b64decode(data)
    elif mode in {'2', 'uu'}:
        data = codecs.decode(data, 'uu')
    else:
        break
    print(data)
