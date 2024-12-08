class UtilityFunctions:
    # 1.1
    @staticmethod
    def sort_array(arr):
        if not isinstance(arr, list) or not all(isinstance(i, int) for i in arr):
            raise ValueError("Input should be a list of integers.")
        if len(arr) <= 1:
            return arr
        pivot = arr[len(arr) // 2]
        left = [x for x in arr if x < pivot]
        middle = [x for x in arr if x == pivot]
        right = [x for x in arr if x > pivot]
        return UtilityFunctions.sort_array(left) + middle + UtilityFunctions.sort_array(right)

    # 1.2
    @staticmethod
    def is_palindrome(s):
        if not isinstance(s, str) or len(s) == 0:
            raise ValueError("Input should be a string.")
        return s == s[::-1]

    # 1.3
    @staticmethod
    def factorial(n):
        if not isinstance(n, int) or n < 0:
            raise ValueError("Input should be a non-negative integer.")
        if n == 0:
            return 1
        result = 1
        for i in range(1, n + 1):
            result *= i
        return result

    # 1.4
    @staticmethod
    def fibonacci(n):
        if not isinstance(n, int) or n < 0:
            raise ValueError("Input should be a non-negative integer.")
        a, b = 0, 1
        for _ in range(n):
            a, b = b, a + b
        return a

    # 1.5
    @staticmethod
    def find_substring(main_string, sub_string):
        if not isinstance(main_string, str) or not isinstance(sub_string, str):
            raise ValueError("Both inputs should be strings.")
        return main_string.find(sub_string)

    # 1.6
    @staticmethod
    def is_prime(n):
        if not isinstance(n, int) or n <= 1:
            return False
        if n <= 3:
            return True
        if n % 2 == 0 or n % 3 == 0:
            return False
        i = 5
        while i * i <= n:
            if n % i == 0 or n % (i + 2) == 0:
                return False
            i += 6
        return True

    # 1.7
    @staticmethod
    def reverse_integer(x):
        if not isinstance(x, int):
            raise ValueError("Input should be an integer.")
        negative = x < 0
        x = abs(x)
        reversed_x = int(str(x)[::-1])
        if reversed_x > 2 ** 31 - 1:
            return 0
        return -reversed_x if negative else reversed_x

    # 1.8
    @staticmethod
    def int_to_roman(x):
        if not isinstance(x, int) or x <= 0 or x > 3999:
            raise ValueError("Input should be an integer between 1 and 3999.")
        roman_numerals = [
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        ]
        result = ""
        for value, symbol in roman_numerals:
            while x >= value:
                result += symbol
                x -= value
        return result
