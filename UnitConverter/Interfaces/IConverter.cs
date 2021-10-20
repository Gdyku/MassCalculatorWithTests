using System;

namespace UnitConverter.Interfaces
{
    public interface IConverter
    {
        decimal Convert(decimal weight, int outputUnit);
    }
}
