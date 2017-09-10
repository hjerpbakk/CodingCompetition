class TestBase:
	def __init__(self):
		self.results = [0,0,0,0,0]

	def Succeeded(self, n):
		self.results[n - 1] = 1

	def TestEndend(self):
		resultString = ",".join(str(v) for v in self.results)
		f = open("C:\\Users\\roh\\AppData\\Roaming\\DIPS Coding Competition\\results.txt", "w")
		f.write(resultString)
		f.close()