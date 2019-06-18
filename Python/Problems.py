from TestBase import TestBase
from Solution import yearsAlive
import unittest
from datetime import date, timedelta

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		self.assertEqual(0, yearsAlive(date.today()))
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		self.assertEqual(1, yearsAlive(date.today() - timedelta(days=366)))
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		self.assertEqual(10, yearsAlive(date.today() - timedelta(days=366*10)))
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		self.assertEqual(50, yearsAlive(date.today() - timedelta(days=366*50)))
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		self.assertEqual(100, yearsAlive(date.today() - timedelta(days=366*100)))
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
