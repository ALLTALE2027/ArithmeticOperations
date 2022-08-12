namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic operations!!!");

            Console.WriteLine("Enter the two  numbers");
            float firstNumber=float.Parse(Console.ReadLine());
            float secondNumber= float.Parse(Console.ReadLine());


            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("select which Arithmetic operation  you want to perform ");
            int ans=int.Parse(Console.ReadLine());


            Arithmetic operation=new Arithmetic();

            switch (ans) 
            {
                case 1: operation.Add(firstNumber,secondNumber);
                    break;
                
                case 2: operation.Subtract(firstNumber, secondNumber);
                    break;
               
                case 3: operation.Multiply(firstNumber, secondNumber);
                    break;
                
                case 4: operation.Divide(firstNumber, secondNumber);
                    break;
                
                default:Console.WriteLine("Enter valid selection");
                    break;

            }


        }
    }
}