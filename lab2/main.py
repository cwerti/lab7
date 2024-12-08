def factorial(n):
    if n == 0 or n == 1:
        return 1
    result = 1
    for i in range(2, n + 1):
        result *= i
    return result


def power(x, n):
    result = 1
    for _ in range(n):
        result *= x
    return result


def taylor_sine(x, terms=10):
    result = 0
    for n in range(terms):
        term = power(-1, n) * power(x, 2 * n + 1) / factorial(2 * n + 1)
        result += term
    return result


def taylor_cosine(x, terms=10):
    result = 0
    for n in range(terms):
        term = power(-1, n) * power(x, 2 * n) / factorial(2 * n)
        result += term
    return result


def taylor_ln(x, terms=10):
    if x <= 0:
        raise ValueError("Natural logarithm is undefined for non-positive values.")
    x -= 1
    result = 0
    for n in range(1, terms + 1):
        term = power(-1, n - 1) * power(x, n) / n
        result += term
    return result


def my_function(x):
    if x > 0:
        return taylor_ln(x) * taylor_cosine(x)
    else:
        return abs(taylor_sine(x) - taylor_cosine(x)) / taylor_ln(abs(x)) + 1
