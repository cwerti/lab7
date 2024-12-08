import unittest
from main import UtilityFunctions


class TestClass(unittest.TestCase):

    def setUp(self):
        self.test_class = UtilityFunctions()

    def test_sort_array(self):
        self.assertEqual(self.test_class.sort_array([1, 5, 3]), [1, 3, 5])
        self.assertEqual(self.test_class.sort_array([1, 2, 3]), [1, 2, 3])
        self.assertEqual(self.test_class.sort_array([6, 1, 2]), [1, 2, 6])
        self.assertEqual(self.test_class.sort_array([1, 7, 1]), [1, 1, 7])
        self.assertEqual(self.test_class.sort_array([]), [])

        with self.assertRaises(ValueError):
            self.test_class.sort_array("qwe")

    def test_fibonacci(self):
        self.assertEqual(self.test_class.fibonacci(1), 1)
        self.assertEqual(self.test_class.fibonacci(2), 1)
        self.assertEqual(self.test_class.fibonacci(3), 2)
        self.assertEqual(self.test_class.fibonacci(4), 3)
        self.assertEqual(self.test_class.fibonacci(0), 0)
        with self.assertRaises(ValueError):
            self.test_class.fibonacci(-5)
        with self.assertRaises(ValueError):
            self.test_class.fibonacci("qwe")
        with self.assertRaises(ValueError):
            self.test_class.fibonacci("")

    def test_find_substring(self):
        self.assertEqual(self.test_class.find_substring("qwe", 'qw'), 0)
        self.assertEqual(self.test_class.find_substring("qwe", "we"), 1)
        self.assertEqual(self.test_class.find_substring("01234", "123"), 1)
        self.assertEqual(self.test_class.find_substring("1233", "8"), -1)
        self.assertEqual(self.test_class.find_substring("qwe", "qweqweqwe"), -1)
        self.assertEqual(self.test_class.find_substring("", "qwe"), -1)
        self.assertEqual(self.test_class.find_substring("qwe", ""), 0)

        with self.assertRaises(ValueError):
            self.test_class.find_substring("qwe", 123)

    def test_is_prime(self):
        self.assertEqual(self.test_class.is_prime(6), False)
        self.assertEqual(self.test_class.is_prime(11), True)
        self.assertEqual(self.test_class.is_prime(7), True)
        self.assertEqual(self.test_class.is_prime(2), True)
        self.assertEqual(self.test_class.is_prime(111), False)
        self.assertEqual(self.test_class.is_prime(-1), False)
        self.assertEqual(self.test_class.is_prime(307), True)
        self.assertEqual(self.test_class.is_prime(35), False)

    def test_reverse_integer(self):
        self.assertEqual(self.test_class.reverse_integer(123), 321)
        self.assertEqual(self.test_class.reverse_integer(-21), -12)
        self.assertEqual(self.test_class.reverse_integer(-120), -21)
        self.assertEqual(self.test_class.reverse_integer(45), 54)
        self.assertEqual(self.test_class.reverse_integer(123123123123123123123), 0)
        with self.assertRaises(ValueError):
            self.test_class.reverse_integer("qwe")

    def test_int_to_roman(self):
        self.assertEqual(self.test_class.int_to_roman(50), 'L')
        self.assertEqual(self.test_class.int_to_roman(1000), 'M')
        self.assertEqual(self.test_class.int_to_roman(1230), 'MCCXXX')
        with self.assertRaises(ValueError):
            self.test_class.int_to_roman("qwe")

    def test_is_palindrome(self):
        self.assertEqual(self.test_class.is_palindrome("qweewq"), True)
        self.assertEqual(self.test_class.is_palindrome("qwe"), False)
        with self.assertRaises(ValueError):
            self.test_class.is_palindrome("")

    def test_factorial(self):
        with self.assertRaises(ValueError):
            self.test_class.factorial("123")
        with self.assertRaises(ValueError):
            self.test_class.factorial("")
        self.assertEqual(self.test_class.factorial(0), 1)
        self.assertEqual(self.test_class.factorial(1), 1)


# Executing the tests in the above test case class
if __name__ == "__main__":
    unittest.main()
