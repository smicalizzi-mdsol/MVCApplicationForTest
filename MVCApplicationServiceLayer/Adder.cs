namespace MVCApplicationServiceLayer
{
    public class Adder : IAdder
    {
        public int Add(int integerOne, int integerTwo)
        {
            return integerOne + integerTwo;
        }

        public string AddTwoNumbers(string numberOne, string numberTwo)
        {
            NumberConverter numberConverterFunctionality = new NumberConverter();

            int integerOne = numberConverterFunctionality.ConvertNumber(numberOne);
            int integerTwo = numberConverterFunctionality.ConvertNumber(numberTwo);
            int result = Add(integerOne, integerTwo);

            return "The result is \"" + result + "\"";
        }
    }
}
