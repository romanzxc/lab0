using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_0
{
    internal class Program
    {
        /// <summary>
        /// Вычисления разности двух вещественных чисел
        /// </summary>
        /// <param name="firstNumber"> Первое вещественное число</param>
        /// <param name="second">Второе вещественное число</param>
        /// <returns> разность двух вещественных чисел </returns>
        private static double DifferenceOfTwoRealNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double firstNumber = rnd.NextDouble();
            double secondNumber = rnd.NextDouble();
            Console.WriteLine("Вариант 6 : Реализовать функцию вычисления разности двух вещественных чисел ");
            Console.WriteLine($" Первое число:{firstNumber} ; Второе число:{secondNumber} ; \n  Разность вещественных чисел: {DifferenceOfTwoRealNumbers(firstNumber, secondNumber)}");
            Console.ReadLine();
        }
    }
}
