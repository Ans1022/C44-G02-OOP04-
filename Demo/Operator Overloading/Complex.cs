using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        //Operator Overloading
        //+ 
        // must Be : Public - Static
        // Binary : + - % * / 

        public static Complex operator +(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = left.Real + Right.Real,
                Imag = left.Imag + Right.Imag
                
            };
        } 
        public static Complex operator -(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = left.Real - Right.Real,
                Imag = left.Imag - Right.Imag
                
            };

        }
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            return new Complex();
        }

        //Comparision Operator Binary : > < 
        // must Bool

        public static bool operator >(Complex left, Complex Right)
        {
            if(left.Real == Right.Real)
                return left.Imag > Right.Imag;
            return left.Real > Right.Real;
            
        }        
        public static bool operator <(Complex left, Complex Right)
        {
            if (left.Real == Right.Real)
                return left.Imag < Right.Imag;
            return left.Real < Right.Real;
        }

        // User-Defined Casting Operator 
        // Complex ==> String
        // Function ==> Public - Static
        // // impilict - Explicit

        public static explicit operator string(Complex complex)
        {
           // return "Hello Anas !";
           return complex.ToString(); 

        }

        public static implicit operator int(Complex complex)
        {
            return complex.Real;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i ";
        }
    }
}
