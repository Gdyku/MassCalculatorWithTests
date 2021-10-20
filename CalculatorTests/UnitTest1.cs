using NUnit.Framework;
using UnitConverter.Converters;
using UnitConverter.Interfaces;
using UnitConverter;

namespace CalculatorTests
{
    public class Tests
    {
        private GramConverter gramConverter;
        private LbsConverter lbsConverter;
        private MgConverter mgConverter;
        private OzConverter ozConverter;
        private ICalculator calculator;

        [SetUp]
        public void Setup()
        {
            gramConverter = new GramConverter();
            lbsConverter = new LbsConverter();
            mgConverter = new MgConverter();
            ozConverter = new OzConverter();
            calculator = new UnitCalculator();
        }

        [TestCase(2, 2, 1)]
        [TestCase(2, 1000 * 2, 2)]
        [TestCase(2, 0.0022046226 * 2, 3)]
        [TestCase(2, 0.0352739619 * 2, 4)]
        public void GramConverterTest(int input, decimal expected, int unit)
        {
            var result = gramConverter.Convert(input, unit);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 0.001 * 2, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(2, 0.0000022046 * 2, 3)]
        [TestCase(2, 0.000035274 * 2, 4)]
        public void MiligramConverterTest(int input, decimal expected, int unit)
        {
            var result = mgConverter.Convert(input, unit);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 2 * 453.59237, 1)]
        [TestCase(2, 453592.37 * 2, 2)]
        [TestCase(2, 2, 3)]
        [TestCase(2, 16 * 2, 4)]
        public void PoundsConverterTest(int input, decimal expected, int unit)
        {
            var result = lbsConverter.Convert(input, unit);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 28.349523125 * 2, 1)]
        [TestCase(2, 28349.523125 * 2, 2)]
        [TestCase(2, 0.0625 * 2, 3)]
        [TestCase(2, 2, 4)]
        public void OuncesConverterTest(int input, decimal expected, int unit)
        {
            var result = ozConverter.Convert(input, unit);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, 3, 1, 1)]
        [TestCase(3, 1000 * 3, 1, 2)]
        [TestCase(3, 0.0022046226 * 3, 1, 3)]
        [TestCase(3, 0.0352739619 * 3, 1, 4)]
        [TestCase(3, 0.001 * 3, 2, 1)]
        [TestCase(3, 3, 2, 2)]
        [TestCase(3, 0.0000022046 * 3, 2, 3)]
        [TestCase(3, 0.000035274 * 3, 2, 4)]
        [TestCase(3, 3 * 453.59237, 3, 1)]
        [TestCase(3, 453592.37 * 3, 3, 2)]
        [TestCase(3, 3, 3, 3)]
        [TestCase(3, 16 * 3, 3, 4)]
        [TestCase(3, 28.349523125 * 3, 4, 1)]
        [TestCase(3, 28349.523125 * 3, 4, 2)]
        [TestCase(3, 0.0625 * 3, 4, 3)]
        [TestCase(3, 3, 4, 4)]
        public void UnitCalculatorTest(int inputWeight, decimal expected, int sourceUnit, int outputUnit)
        {
            var result = calculator.CalculateUnits(inputWeight, sourceUnit, outputUnit);
            Assert.AreEqual(expected, result);
        }    
    }
}