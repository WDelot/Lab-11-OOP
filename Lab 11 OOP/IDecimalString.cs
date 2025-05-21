using System;

namespace Lab_11_OOP
{
    public interface IDecimalString : ICloneable, IComparable
    {
        bool IsValid { get; }
        IDecimalString Difference(IDecimalString otherString);
        bool IsGreaterThan(IDecimalString otherString);
        bool IsLessThan(IDecimalString otherString);
        string ToString();
    }
}