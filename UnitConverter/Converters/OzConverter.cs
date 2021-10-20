using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Interfaces;

namespace UnitConverter.Converters
{
    public class OzConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch (outputUnit)
            {
                case 1:
                    result = ConvertOzToGrams(weight);
                    return result;
                case 2:
                    result = ConvertOzToMiligrams(weight);
                    return result;
                case 3:
                    result = ConvertOzToPounds(weight);
                    return result;
                case 4:
                    result = weight;
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertOzToGrams(decimal weight)
        {
            decimal grams = weight * (decimal)28.349523125;
            return grams;
        }

        private decimal ConvertOzToMiligrams(decimal weight)
        {
            decimal miligrams = weight * (decimal)28349.523125;
            return miligrams;
        }

        private decimal ConvertOzToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0625;
            return pounds;
        }

        
    }
}
