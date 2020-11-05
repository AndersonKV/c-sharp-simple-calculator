using System;

namespace simplesCalculator
{
    class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertNumber;

            if (!double.TryParse(argTextInput, out convertNumber)) throw new ArgumentException("expected a number value");
            return convertNumber;
        }
    }
}