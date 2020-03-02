using System;

namespace assign_3
{

    class GenericInput<T> 
    {
        private T genericVariable;

        public GenericInput(T value)
        {
            genericVariable = value;
        }

        public void GenericMethod()
        {
            Console.WriteLine($"Your input was: {genericVariable}");
            Console.WriteLine($"Your input type was: {typeof(T).ToString()}");
        }
    }

    class GenericInputTwo<T, V> 
    {
        private dynamic genericOne;
        private dynamic genericTwo;

        public GenericInputTwo(T oneVal, V twoVal)
        {
            genericOne = oneVal;
            genericTwo = twoVal;
        }

        public void Combine()
        {
            dynamic combo = genericOne + genericTwo;
            Console.WriteLine($"Your combined input is: {combo}");
            Console.WriteLine($"Your first input type was: {typeof(T).ToString()}");
            Console.WriteLine($"Your second input type was: {typeof(V).ToString()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericInput<int> intInput = new GenericInput<int>(50);
            intInput.GenericMethod();
            GenericInput<string> stringInput = new GenericInput<string>("Cat");
            stringInput.GenericMethod();
            GenericInput<double> doubleInput = new GenericInput<double>(1.57);
            doubleInput.GenericMethod();

            GenericInputTwo<int, double> comboOne = new GenericInputTwo<int, double>(5, 1.7);
            comboOne.Combine();
            GenericInputTwo<int, string> comboTwo = new GenericInputTwo<int, string>(5, "Cat");
            comboTwo.Combine();

        }
    }
}
