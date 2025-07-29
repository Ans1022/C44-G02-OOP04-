using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Demo.Abstraction;
using Demo.Mapping;
using Demo.Operator_Overloading;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        public static string Email { get; private set; }

        static void Main(string[] args)
        {
            #region Abstraction
            //abstract : C# KeyWord [Class = Methods = properties]
            //abstract Class
            //abstract properties
            //abstract Methods
            //NOTE : Can't Create Object from Abstract Class


            //Abstraction.Rectangle rectangle = new Abstraction.Rectangle() {Dim01 = 10 , Dim02 = 20 };
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.GetArea());

            //rectangle.Print();
            #endregion

            #region Interface Vs Abstract Class
            // abstract : Class 
            // Interface : Contract
            #endregion

            #region Operator Overloading [ - + Operator]
            // Complex Number : Real + imag
            // 3 + 4 t
            // 4 + 4 ت

            //Complex C01 = new Complex() { Real = 3 , Imag = 4 };
            //Complex C02 = new Complex() { Real = 2 , Imag = 5 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            // Complex C03 = C01 + C02;
            ////Complex C03 = C01 - C02;
            //Console.WriteLine(C03);




            #endregion

            #region Operator Overloading - (++ Operator)
            // Unray Operator

            //Complex C01 = new Complex() { Real = 3 , Imag = 4 };
            //Console.WriteLine(C01);
            //C01++;
            //Console.WriteLine(C01);

            #endregion

            #region Operator Overloading - (Comparision Operator)
            //Complex C01 = new Complex() { Real = 7 , Imag = 4 };
            //Complex C02 = new Complex() { Real = 4 , Imag = 2 };

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 Is grater then C02");
            //}
            //else 
            //{
            //    Console.WriteLine("C01 Is Not grater then C02");
            //}
            #endregion

            #region User-Defined Casting Operator (Manual Mapping)
            //Complex C01 = new Complex() {Real = 4 , Imag = 2 };
            //string S =(string) C01;
            //Console.WriteLine(S);

            //int X = /*(int)*/ C01;
            //Console.WriteLine(X);


            //User user = new User();
            //Manual Mapping
            //UserDto dto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    PhoneNumber = user.PhoneNumber
            //};

            // Casting Operator

            //Automapper :  Mapping Automatic
            #endregion

            #region C# KeyWord Static [Class, Method, Consteuctor, Property, Attributes]
            // static Class
            // static Method
            // static Consteuctor
            // static Property
            // static Attributes

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();

            //Console.WriteLine(U01.CmtoInch(245)); //100
            //Console.WriteLine(Utilities.CmtoInch(245)); //100

            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);



            #endregion

            #region  Sealed (Class, Method, Property)



            #endregion

            #region  Partial Classes

            Employee employee = new Employee();
           

            #endregion
        }
    }
}
