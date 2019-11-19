using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Complex
    {
        public double RealPart { get; private set; }
        public double ImPart { get; private set; }
        public Complex(double Re, double Im)
        {
            this.RealPart = Re;
            this.ImPart = Im;
        }

        // deafult constructor
        public Complex()
        {

        }

        /// <summary>
        /// Additon,Subtraction,Multiply,Division
        /// </summary>
        /// <param name="Comlex other" ></param>
        /// <returns> Complex result </returns>
        public Complex Addition(Complex other)
        {
            Complex result = new Complex();
            result.RealPart = other.RealPart + this.RealPart;
            result.ImPart = other.ImPart + this.ImPart;
            return result;
        }
        public Complex Subtraction(Complex other)
        {
            Complex result = new Complex();
            result.RealPart = this.RealPart - other.RealPart;
            result.ImPart = this.ImPart - other.ImPart;
            return result;
        }       
        public Complex Multiply(Complex other)
        {
            Complex result = new Complex();
            result.RealPart = (other.RealPart * this.RealPart) + (-1) * (this.ImPart * other.ImPart);
            result.ImPart = (other.RealPart * this.ImPart) + (-1) * (this.ImPart * other.RealPart);
            return result;
        }
        public Complex Division(Complex other)
        {
            Complex result = new Complex(this.RealPart,this.ImPart);
            result.RealPart = (this.RealPart * other.RealPart - this.ImPart*other.ImPart) / (Math.Pow(other.RealPart,2)+ Math.Pow(other.ImPart, 2));
            result.ImPart = (other.ImPart - other.RealPart*this.ImPart) / (Math.Pow(other.RealPart, 2) + Math.Pow(other.ImPart, 2));
                
            return result;
        }
        public double Absolute()
        {
            double absolute = Math.Sqrt(Math.Pow(this.RealPart,2) + Math.Pow(this.ImPart,2));

            return absolute;
        }
        /// <summary>
        /// Argument
        /// </summary>
        /// <returns> double argument with Radians</returns>
        public double Argument()
        {
            double argument = 0;
            if (this.RealPart>0)
            {
               argument = Math.Atan(this.ImPart / this.RealPart);
            }
            if (this.RealPart < 0 && this.ImPart >= 0)
            {
               argument =  Math.Atan(this.ImPart / this.RealPart) + Math.PI / 180;
            }
            if (this.RealPart < 0 && this.ImPart < 0)
            {
                argument = Math.Atan(this.ImPart / this.RealPart) - Math.PI / 180;
            }
            if (this.RealPart == 0 && this.ImPart > 0)
            {
                argument =  (Math.PI / 2) * 180;
            }
            if (this.RealPart == 0 && this.ImPart < 0)
            {
                argument = -1 * (Math.PI / 2) * 180;
            }


            return argument;
        }

        // Print Trigonometric Form with degrees
        public void PrintTrigonometricForm()
        {
            Console.WriteLine($"{this.Absolute()} * (cos({this.Argument() * 180/Math.PI }) + i*sin({this.Argument() * 180 / Math.PI }))");
        }

        public override string ToString()
        {
            return $"{this.RealPart} + {this.ImPart}i ";
        }
        
    }
}
