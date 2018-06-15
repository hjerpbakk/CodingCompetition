from TestBase import TestBase
from Solution import closestToZero
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		numbers = "0,1,-1,3"
		line = closestToZero(numbers)

		self.assertEqual(0, line)
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		numbers = "45,90,1,1235,17,3,9"
		line = closestToZero(numbers)

		self.assertEqual(1, line)
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		numbers = "32,54,12,2,-2,64,42"
		line = closestToZero(numbers)

		self.assertEqual(-2, line)
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		numbers = "-5,-4,-3,-2,-1"
		line = closestToZero(numbers)

		self.assertEqual(-1, line)
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		numbers = "90,72,17,15,19"
		line = closestToZero(numbers)

		self.assertEqual(15, line)
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
