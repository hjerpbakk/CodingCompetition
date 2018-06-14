from TestBase import TestBase
from Solution import median
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		numbers = "1, 2, 3, 4, 5"
		line = median(numbers)

		self.assertEqual(3, line)
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		numbers = "45, 90, 1, 1235, 17, 3, 9"
		line = median(numbers)

		self.assertEqual(17, line)
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		numbers = "32, 54, 12, 64, 42"
		line = median(numbers)

		self.assertEqual(42, line)
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		numbers = "5, 4, 3, 2, 1"
		line = median(numbers)

		self.assertEqual(3, line)
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		numbers = "90, 72, 17, 15, 19"
		line = median(numbers)

		self.assertEqual(19, line)
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
