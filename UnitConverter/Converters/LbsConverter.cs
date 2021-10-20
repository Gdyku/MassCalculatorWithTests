using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Interfaces;

namespace UnitConverter.Converters
{
    public class LbsConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch (outputUnit)
            {
                case 1:
                    result = ConvertLbsToGrams(weight);
                    return result;
                case 2:
                    result = ConvertLbsToMiligrams(weight);
                    return result;
                case 3:
                    result = weight;
                    return result;
                case 4:
                    result = ConvertLbsToOunces(weight);
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertLbsToGrams(decimal weight)
        {
            decimal grams = weight * (decimal)453.59237;
            return grams;
        }
        private decimal ConvertLbsToMiligrams(decimal weight)
        {
            decimal miligrams = weight * (decimal)453592.37;
            return miligrams;
        }
        private decimal ConvertLbsToOunces(decimal weight)
        {
            decimal ounces = weight * 16;
            return ounces;
        }

    }
}
