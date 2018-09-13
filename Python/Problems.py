from TestBase import TestBase
from Solution import isLeapYear
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		self.assertEqual(True, isLeapYear(2000))
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		self.assertEqual(False, isLeapYear(2015))
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		self.assertEqual(True, isLeapYear(1996))
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		self.assertEqual(False, isLeapYear(2100))
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		self.assertEqual(False, isLeapYear(1997))
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
