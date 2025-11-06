using System;

namespace ConsoleApp11
{
    public class Kalkulator
    {
        public double ObliczBMI(string wzrostStr, string wagaStr)
        {
            double wzrost = double.Parse(wzrostStr) / 100;
            double waga = double.Parse(wagaStr);
            double Bmi = waga / (wzrost * wzrost);
            return Bmi;
        }

        public string InterpretujBmi(double Bmi)
        {
            if (Bmi < 18.5) return "Niedowaga";
            else if (Bmi >= 18.5 && Bmi < 25) return "Waga prawidlowa";
            else if (Bmi >= 25 && Bmi < 30) return "nadwaga";
            else if (Bmi >= 30) return "otylosc";
            else return "blad";
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9.2");
            Console.WriteLine("Podaj swój wzrost (w cm): "); 
            string wzrostStr = Console.ReadLine();
            Console.WriteLine("podaj swoja wage: "); 
            string wagaStr = Console.ReadLine();

            Kalkulator k1 = new Kalkulator();
            double bmi = k1.ObliczBMI(wzrostStr, wagaStr); 
            string interpretacja = k1.InterpretujBmi(bmi);

            Console.WriteLine($"twoje bmi: {bmi:F2}");
            Console.WriteLine($"stan: {interpretacja}");
        }
    }
}
