using System;

namespace HomeWork04._04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Введите сколько долларов стоит 100 сомон: ");
            double usd = double.Parse(Console.ReadLine());
            System.Console.Write("Введите сколько рублей стоит 100 сомон: ");
            double rub = double.Parse(Console.ReadLine());
            System.Console.Write("Введите сколько евро стоит 100 сомон: ");
            double eur = double.Parse(Console.ReadLine());
            Converter converter = new Converter(usd,rub,eur){};
            System.Console.Write("1. usd = доллар\n2. rub = рубль\n3. eur = евро\n");
            Console.ReadKey();
        }
    }
    class Converter 
    {

        public double usd {get;set;}
        public double rub {get;set;}
        public double eur {get;set;}
        public Converter(double usd, double rub, double eur)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
            System.Console.WriteLine($"{usd} доллар = 100 сомон\n{rub} рубль = 100 сомон\n{eur} евро = 100 сомон");
        }
        public double ConvertToSomoni (double currency,double muchMoney)
        {
            
            return 1;
        }
    }
}
