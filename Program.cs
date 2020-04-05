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
            System.Console.Write("Введите сколько сомон хотите конвертировать: ");
            double muchMoney = double.Parse(Console.ReadLine());
            System.Console.WriteLine("usd или доллар - для вывода конвертации в долларах\nrub или рубль - для вывода конвертации в рублях\neur или евро - для вывода конвертации в евро\nall или все - для вывода конвертации во всех валютах");
            System.Console.Write("Введите в какую валюту: ");
            string vKurs = Console.ReadLine();
            // System.Console.Write("Введите количество конвертирующих денег: ");
            // double muchMoney1 = double.Parse(Console.ReadLine());
            if(vKurs == "евро" || vKurs == "eur")
            {
                Console.WriteLine(ConvertToAnotherCurrency(muchMoney,eur));
            }
            System.Console.WriteLine(vKurs == "доллар" || vKurs == "usd"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.usd)} usd":
            vKurs == "rub" || vKurs == "рубль"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.rub)} rub":
            vKurs == "eur" || vKurs == "евро"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.eur)} rub":
            vKurs == "all" || vKurs == "все"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.usd)} usd\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.rub)} rub\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,converter.eur)} eur":
            $"Такой валюты не существует");
            
            Console.ReadKey();
        }
        static double ConvertToAnotherCurrency(double muchMoney,double currency)
        {
            double result = currency *muchMoney / 100;
            return result;
        }
        static double ConvertToSomoni()
        {
            return 1;
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
            System.Console.WriteLine($"{usd} usd = 100 som\n{rub} rub = 100 som\n{eur} eur = 100 som");
        }
        // public double GetConvert (string otKursa,string vKurs, double muchMoney)
        // {
        //     if()
        //     return 1;
        // }
    }
}
