import codecs
f = open('.\question.txt', 'r')
data = f.read()
f.close()
print(codecs.decode(data, 'rot-13'))
