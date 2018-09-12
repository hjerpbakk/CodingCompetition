from TestBase import TestBase
from Solution import distance
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		self.assertEqual(0, distance("GGACTGA", "GGACTGA"))
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		self.assertEqual(1, distance("A", "G"))
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		self.assertEqual(2, distance("AG", "CT"))
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		self.assertEqual(2, distance("ACCAGGG", "ACTATGG"))
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		self.assertEqual(9, distance("GGACGGATTCTG", "AGGACGGATTCT"))
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
