import unittest
from main import *


class TestMathFunctions(unittest.TestCase):
    def test_factorial(self):
        self.assertEqual(factorial(0), 1)
        self.assertEqual(factorial(1), 1)
        self.assertEqual(factorial(5), 120)

    def test_power(self):
        self.assertEqual(power(2, 0), 1)
        self.assertEqual(power(2, 3), 8)
        self.assertEqual(power(5, 2), 25)

    def test_taylor_sine(self):
        self.assertAlmostEqual(taylor_sine(0), 0, places=5)
        self.assertAlmostEqual(taylor_sine(3.14159 / 2), 1, places=3)

    def test_taylor_cosine(self):
        self.assertAlmostEqual(taylor_cosine(0), 1, places=5)
        self.assertAlmostEqual(taylor_cosine(3.14159), -1, places=3)

    def test_taylor_ln(self):
        with self.assertRaises(ValueError):
            taylor_ln(-21)
        self.assertAlmostEqual(taylor_ln(2), 0.6456, places=3)
        self.assertAlmostEqual(taylor_ln(1), 0.0, places=3)

    def test_my_function_over_zero(self):
        self.assertAlmostEqual(my_function(5), taylor_ln(5) * taylor_cosine(5), places=5)

    def test_my_function_under_zero(self):
        self.assertAlmostEqual(my_function(-2), abs(taylor_sine(-2) - taylor_cosine(-2)) / taylor_ln(abs(-2)) + 1,
                               places=5)

    def test_my_function(self):
        self.assertAlmostEqual(my_function(10), taylor_ln(10) * taylor_cosine(10), places=5)


if __name__ == "__main__":
    unittest.main()
