using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Interfaces;

namespace UnitConverter.Converters
{
    public class MgConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch (outputUnit)
            {
                case 1:
                    result = ConvertMgToGrams(weight);
                    return result;
                case 2:
                    result = weight;
                    return result;
                case 3:
                    result = ConvertMgToPounds(weight);
                    return result;
                case 4:
                    result = ConvertMgToOunces(weight);
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertMgToGrams(decimal weight)
        {
            decimal grams = weight * (decimal)0.001;
            return grams;
        }

        private decimal ConvertMgToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0000022046;
            return pounds;
        }

        private decimal ConvertMgToOunces(decimal weight)
        {
            decimal ounces = weight * (decimal)0.000035274;
            return ounces;
        }
    }
}
