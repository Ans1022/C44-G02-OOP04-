using Assignment.Assignment;
using Assignment.Task;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 
            //Food food = new Food(6);
            //food.Show();
            //food++;
            //food.Show();
            #endregion


            #region Q1

            Console.WriteLine("======================(first Project)=====================");
            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();
            Console.WriteLine(D1);

            D1 = new Duration(3600);
            D1.ToString();
            Console.WriteLine(D1); 

            Duration D2 = new Duration(7800);
            D2.ToString();
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            D3.ToString();
            Console.WriteLine(D3); 

            Console.WriteLine("----------------------------------------");


            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2 " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800 " + D3);

            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3 " + D3);

            D3 = ++D1;
            Console.WriteLine("D3 = ++D1 " + D3);

            D3 = --D2;
            Console.WriteLine("D3 = --D2 " + D3);

            D1 = D1 - D2;
            Console.WriteLine("D1 = D1 - D2 " + D1);

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D2 is greater than or equal to D1");

            Console.WriteLine("==================(Second Project)==================");

            Console.WriteLine("Add: " + Maths.Add(10, 5));
            Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
            Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
            Console.WriteLine("Divide: " + Maths.Divide(10, 5));

            #endregion
        }
    }
}
