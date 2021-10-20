using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Interfaces;

namespace UnitConverter.Converters
{
    public class GramConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch (outputUnit)
            {
                case 1:
                    result = weight;
                    return result;
                case 2:
                    result = ConvertGramsToMiligrams(weight);
                    return result;
                case 3:
                    result = ConvertGramsToPounds(weight);
                    return result;
                case 4:
                    result = ConvertGramsToOunces(weight);
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertGramsToMiligrams(decimal weight)
        {
            decimal miligrams = weight * 1000;
            return miligrams;
        }
        private decimal ConvertGramsToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0022046226;
            return pounds;
        }
        private decimal ConvertGramsToOunces(decimal weight)
        {
            decimal ounces = weight * (decimal)0.0352739619;
            return ounces;
        }
    }
}
