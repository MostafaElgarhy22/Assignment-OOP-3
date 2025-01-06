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
            //ComplexNumber c1 = new ComplexNumber(5.0, 8.0);
            //ComplexNumber c2 = new ComplexNumber(2.6, 1.5);

            //ComplexNumber sum = c1 + c2;
            //ComplexNumber Subtract = c1 - c2;

            //Console.WriteLine($"Sum = {sum}");        
            //Console.WriteLine($"Subtract = {Subtract}"); 
            #endregion
            #region Part 1 Question 4
            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            #endregion
            #region Part 1 Question 5
            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //DerivedClass1 derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage();
            //DerivedClass2 derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();
            ////--------------------------------- 
            //BaseClass obj1 = new DerivedClass1();
            //obj1.DisplayMessage(); 

            //BaseClass obj2 = new DerivedClass2();
            //obj2.DisplayMessage();         // it happened here in (compile time) so the output will be "Message from BaseClass" and "Message from BaseClass"



            #endregion
            //--------------------------------------------------
            #region Part 2

            //Duration duration1 = new Duration(3, 42, 47);
            //Duration duration2 = new Duration(7500);
            //Console.WriteLine(duration1);
            //Console.WriteLine(duration2);

            //  -----------------------------------------------

            Duration D1 = new Duration(5, 54, 17);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(200000);
            Duration D4 = new Duration(8900);

            Duration result = D1 + D2;
            Console.WriteLine(result);
            Duration result2 = D1 + 1000;
            Console.WriteLine(result2);
            Duration result3 = D1++;
            Console.WriteLine(result3);
            Duration result4 = D1--;
            Console.WriteLine(result4);
            Duration result5 = D1 - D2;
            Console.WriteLine(result5);
            Console.WriteLine(D1 > D2);
            Console.WriteLine(D1 <= D2);
            Console.WriteLine(D1);
            #endregion
        }
    }
}
