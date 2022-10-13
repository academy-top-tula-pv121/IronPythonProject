'''
num = int(input("input number: "))
if num % 2 == 0:
	print("even")
else:
	print("odd")
'''

#a = 100
#c = a + b
#print("result = " + str(c))

def GaussSum(n):
	r = 0;
	for i in range(1, n + 1):
		r += i
	return r
