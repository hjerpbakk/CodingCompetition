from TestBase import TestBase
from Solution import distinctConcat
import unittest

# These are the tests
# Do not change this class
class Problems(unittest.TestCase):
	@classmethod
	def setUpClass(cls):
		cls.testBase = TestBase()

	def test_dips_fact_1(self):
		dips_fact = "DIPS AS is a great place to work"
		line = distinctConcat(dips_fact)

		self.assertEqual("DIPS AS is a great place to work", line)
		Problems.testBase.Succeeded(1)

	def test_dips_fact_2(self):
		dips_fact = "DIPS AS is a great place to work. \nWe have open positions"
		line = distinctConcat(dips_fact)

		self.assertEqual("DIPS AS is a great place to work. We have open positions", line)
		Problems.testBase.Succeeded(2)

	def test_dips_fact_3(self):
		dips_fact = "DIPS AS is a great place to work. \nWe have open positions \nin Trondheim, Bodø, Oslo and Tromsø"
		line = distinctConcat(dips_fact)

		self.assertEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", line)
		Problems.testBase.Succeeded(3)

	def test_dips_fact_4(self):
		dips_fact = "DIPS AS is a great place to work. \nWe have open positions \nin Trondheim, Bodø, Oslo and Tromsø\nin Trondheim, Bodø, Oslo and Tromsø"
		line = distinctConcat(dips_fact)

		self.assertEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", line)
		Problems.testBase.Succeeded(4)

	def test_dips_fact_5(self):
		dips_fact = "DIPS AS is a great place to work. \nDIPS AS is a great place to work. \nWe have open positions \nin Trondheim, Bodø, Oslo and Tromsø. \nin Trondheim, Bodø, Oslo and Tromsø. \nCome join us!";
		line = distinctConcat(dips_fact)

		self.assertEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø. Come join us!", line)
		Problems.testBase.Succeeded(5)

	@classmethod
	def tearDownClass(cls):
		cls.testBase.TestEndend()
		return super().tearDownClass()

if __name__ == '__main__':
	unittest.main()
