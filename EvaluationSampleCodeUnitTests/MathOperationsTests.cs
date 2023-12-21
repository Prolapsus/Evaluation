
using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]

        public void Initialize()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(9, 11, 20)]
        public void Add_ShouldReturnSum(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Add(numberOne, numberTwo);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(6, 2, 3)]
        [DataRow(1, 1, 1)]
        [DataRow(10, 2, 5)]
        public void DivideTest_ShouldReturnDivision(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_WithSecondNumberAsZero_ShouldThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(10, 0));
        }

        [TestMethod]
        public void GetOddNumbers_ShouldThrowExceptionForNegativeLimit()
        {
            var mathOperations = new MathOperations();
            var limit = -5;

            Assert.ThrowsException<ArgumentException>(() => mathOperations.GetOddNumbers(limit));
        }


    }  
}
