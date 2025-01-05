namespace Assignment_OOP_3
{
    internal class Program
    {
        public class Calculator
        {
            #region Part 1 Question 1
            //public int Add(int a, int b)
            //{
            //    return a + b;
            //}

            //public int Add(int a, int b, int c)
            //{
            //    return a + b + c;
            //}

            //public double Add(double a, double b)
            //{
            //    return a + b;
            //}
            #endregion
        }
        static void Main(string[] args)
        {
            #region Part 1 Question 1
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(6, 4));
            //Console.WriteLine(calculator.Add(4, 2, 5));
            //Console.WriteLine(calculator.Add(2.5, 4.7));
            #endregion
            #region Part 1 Question 2

            //Rectangle recta1 = new Rectangle();
            //Console.WriteLine($"Rectangle 1: Width={recta1.Width}, Height={recta1.Height}"); 

            //Rectangle recta2 = new Rectangle(15, 25);
            //Console.WriteLine($"Rectangle 2: Width={recta2.Width}, Height={recta2.Height}"); 

            //Rectangle recta3 = new Rectangle(15);
            //Console.WriteLine($"Rectangle 3: Width={recta3.Width}, Height={recta3.Height}");
            #endregion
            #region Part 1 Question 3
            ComplexNumber c1 = new ComplexNumber(5.0, 8.0);
            ComplexNumber c2 = new ComplexNumber(2.6, 1.5);

            ComplexNumber sum = c1 + c2;
            ComplexNumber Subtract = c1 - c2;

            Console.WriteLine($"Sum = {sum}");        
            Console.WriteLine($"Subtract = {Subtract}"); 
            #endregion
        }
    }
}
