from TestBase import TestBase
from Solution import extractNumber
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		dips_fact = "DIPS AS har 6 kontorer: Trondheim, Bodø, Tromsø, Oslo, Bergen og Stockholm."
		number = extractNumber(dips_fact)

		self.assertEqual(6, number)
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		dips_fact = "DIPS AS har hatt bursdag og i år fylte vi 30 :)"
		number = extractNumber(dips_fact)

		self.assertEqual(20, number)
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		dips_fact = "DIPS AS lager pasientdatasystemer for 85 % av det norske markedet."
		number = extractNumber(dips_fact)

		self.assertEqual(85, number)
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		dips_fact = "DIPS blir brukt av over 80000 brukere hver dag."
		number = extractNumber(dips_fact)

		self.assertEqual(80000, number)
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		dips_fact = "DIPS AS har 280 fantastiske medarbeidere som venter spent på å treffe akkurat deg."
		number = extractNumber(dips_fact)

		self.assertEqual(280, number)
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
