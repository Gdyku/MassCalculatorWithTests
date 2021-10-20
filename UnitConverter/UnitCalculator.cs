using UnitConverter.Interfaces;
using UnitConverter.Converters;

namespace UnitConverter
{
    public class UnitCalculator : ICalculator
    {
        public decimal CalculateUnits(decimal weight, int sourceUnit, int outputUnit)
        {
            IConverter converter = null;
            switch (sourceUnit)
            {
                case 1:
                    converter = new GramConverter();
                    break;
                case 2:
                    converter = new MgConverter();
                    break;
                case 3:
                    converter = new LbsConverter();
                    break;
                case 4:
                    converter = new OzConverter();
                    break;
            }

            var convertedValue = converter.Convert(weight, outputUnit);
            return convertedValue;
        }
    }
}
