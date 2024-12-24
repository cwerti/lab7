using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;

namespace TestProgram
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void TestSortArray_SortedArray()
        {
            var input = new[] { 3, 2, 1 };
            var expected = new[] { 1, 2, 3 };
            CollectionAssert.AreEqual(expected, Utility.SortArray(input));
        }

        [TestMethod]
        public void TestSortArray_EmptyArray()
        {
            var input = new int[0];
            var expected = new int[0];
            CollectionAssert.AreEqual(expected, Utility.SortArray(input));
        }

        [TestMethod]
        public void TestSortArray_NullArray_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Utility.SortArray(null as int[]));
        }

        [TestMethod]
        public void TestSortArray_SingleElementArray()
        {
            var input = new[] { 5 };
            var expected = new[] { 5 };
            CollectionAssert.AreEqual(expected, Utility.SortArray(input));
        }

        [TestMethod] 
        public void TestSortArray_NegativeNumbers() 
        { 
            var input = new[] { -1, -3, -2 }; 
            var expected = new[] { -3, -2, -1 }; 
            CollectionAssert.AreEqual(expected, Utility.SortArray(input)); 
        } 

        [TestMethod]
        public void TestIsPalindrome_True()
        {
            Assert.IsTrue(Utility.IsPalindrome("madam"));
        }

        [TestMethod]
        public void TestIsPalindrome_False()
        {
            Assert.IsFalse(Utility.IsPalindrome("hello"));
        }

        [TestMethod]
        public void TestIsPalindrome_EmptyString()
        {
            Assert.IsTrue(Utility.IsPalindrome(""));
        }

        [TestMethod] 
        public void TestIsPalindrome_Numbers() 
        { 
            Assert.IsTrue(Utility.IsPalindrome("12321")); 
        } 

        [TestMethod]
        public void TestIsPalindrome_NullString_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Utility.IsPalindrome(null as string));
        }

        [TestMethod]
        public void TestFactorial_Zero()
        {
            Assert.AreEqual(1, Utility.Factorial(0));
        }

        [TestMethod]
        public void TestFactorial_PositiveNumber()
        {
            Assert.AreEqual(120, Utility.Factorial(5)); // 5! = 120
        }

        [TestMethod]
        public void TestFactorial_NegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utility.Factorial(-1));
        }

        [TestMethod]
        public void TestFactorial_LargeNumber()
        {
            Assert.AreEqual(720, Utility.Factorial(6)); // 6! = 720
        }

        [TestMethod]
        public void TestFibonacci_Zero()
        {
            Assert.AreEqual(0, Utility.Fibonacci(0));
        }

        [TestMethod]
        public void TestFibonacci_PositiveIndex()
        {
            Assert.AreEqual(5, Utility.Fibonacci(5)); // F(5) = 5
        }

        [TestMethod]
        public void TestFibonacci_NegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utility.Fibonacci(-1));
        }

        [TestMethod]
        public void TestFibonacci_FirstIndex()
        {
            Assert.AreEqual(1, Utility.Fibonacci(1)); // F(1) = 1
        }

        [TestMethod]
        public void TestIndexOfSubstring_Found()
        {
            Assert.AreEqual(2, Utility.IndexOfSubstring("hello", "llo"));
        }

        [TestMethod]
        public void TestIndexOfSubstring_NotFound()
        {
            Assert.AreEqual(-1, Utility.IndexOfSubstring("hello", "world"));
        }

        [TestMethod]
        public void TestIndexOfSubstring_EmptyString()
        {
            Assert.AreEqual(-1, Utility.IndexOfSubstring("", "a"));
        }

        [TestMethod]
        public void TestIndexOfSubstring_NullString1_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Utility.IndexOfSubstring("a", null as string));
        }
        
        [TestMethod]
        public void TestIndexOfSubstring_NullString_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Utility.IndexOfSubstring(null as string, "a"));
        }

        [TestMethod] 
        public void TestIndexOfSubstring_Whitespace() 
        { 
            Assert.AreEqual(1, Utility.IndexOfSubstring("hello world", "ello")); // Проверка с пробелами
        } 

        [TestMethod]
        public void TestIsPrime_PrimeNumber()
        {
               Assert.IsTrue(Utility.IsPrime(7));
        }

        [TestMethod]
        public void TestIsPrime_NonPrimeNumber()
        {
               Assert.IsFalse(Utility.IsPrime(4));
        }

        [TestMethod]
        public void TestIsPrime_OneIsNotPrime()
        {
            Assert.IsFalse(Utility.IsPrime(1));
        }
        [TestMethod]
        public void TestIsPrime_NegativeNumber()
        {
               Assert.IsFalse(Utility.IsPrime(-3));
        }

        [TestMethod]
        public void TestReverseInteger_PositiveNumber()
        {
               Assert.AreEqual(321, Utility.ReverseInteger(123));
        }

        [TestMethod]
        public void TestReverseInteger_NegativeNumber()
        {
            Assert.AreEqual(-21, Utility.ReverseInteger(-120));
        }

        [TestMethod]
        public void TestReverseInteger_Overflow()
        {
            Assert.AreEqual(0, Utility.ReverseInteger(int.MaxValue));
        }

        [TestMethod]
        public void TestReverseInteger_SingleDigit()
        {
            Assert.AreEqual(7, Utility.ReverseInteger(7));
        }

        [TestMethod]
        public void TestToRoman_ValidInput()
        {
            Assert.AreEqual("X", Utility.ToRoman(10));
        }

        [TestMethod]
        public void TestToRoman_InvalidInput_Zero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utility.ToRoman(0));
        }

        [TestMethod]
        public void TestToRoman_InvalidInput_Negative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utility.ToRoman(-1));
        }

        [TestMethod]
        public void TestToRoman_InvalidInput_Above3999()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utility.ToRoman(4000));
        }
    }
}