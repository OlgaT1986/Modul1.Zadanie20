using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie20
{
    class Program
    {
        delegate double Mydelegate(double R);
        static void Main(string[] args)
        {
            Mydelegate mydelegate = LengthCircle;
            // вызов метода LengthCircle
            double length = mydelegate(6); 
            Console.WriteLine("{0:0.00}", length);

            mydelegate = SquareCircle;
            // вызов метода SquareCircle
            double square = mydelegate(6); 
            Console.WriteLine("{0:0.00}", square);

            mydelegate = VolumeBall;
            // вызов метода VolumeBall
            double volume = mydelegate(6); 
            Console.WriteLine("{0:0.00}", volume);
            Console.ReadKey();
        }
        //метод получит R и вычисляет длину окружности 
        static double LengthCircle(double R) => (double)Math.PI * 2 * R;
        //метод получит R и вычислит площадь круга
        static double SquareCircle(double R) => (double)Math.PI * R * R;
        //метод получит R и вычислит объем шара
        static double VolumeBall(double R) => (double)4 / 3 * Math.PI * R * R * R;
    }
}

