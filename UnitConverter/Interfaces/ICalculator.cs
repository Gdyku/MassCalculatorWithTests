using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter.Interfaces
{
    public interface ICalculator
    {
        decimal CalculateUnits(decimal weight, int sourceunit, int outputunit);

    }
}
