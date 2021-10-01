//tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input il raggio di una circonferenza
//calcoli e visualizzi in output la misura del diametro (2*r)
//della circonferenza (2*r*pi) e la sua area(r**2 * pi) Math.Pi
using System;

namespace Circonferenza
{
    class Cerchio
    {
        double raggio;
        public Cerchio()
        {
            raggio = 0;
        }
        public bool LeggiDati()
        {
            try
            {
                raggio = Convert.ToDouble(Console.ReadLine());
                if(raggio <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }    
            }
            catch
            {
                return false;
            }
        }
        public double CalcoloDiametro()
        {
            double diametro = 0;
            diametro = this.raggio * 2;
            return diametro;
        }
        public double CalcoloCircoferenza()
        {
            double perimetro = 0;
            perimetro = this.raggio * 2 * Math.PI;
            return perimetro;
        }
        public double CalcoloArea()
        {
            double area = 0;
            area = (this.raggio*this.raggio)*Math.PI;
            return area;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci il valore del raggio:");
            Cerchio c = new Cerchio();
            while(c.LeggiDati() == false)
            {
                Console.WriteLine("Inserisci un valore numerico e maggiore di 0");
            }
            Console.WriteLine("Il valore del diametro è: {0}",c.CalcoloDiametro());
            Console.WriteLine("Il valore della circonferenza è: {0}", c.CalcoloCircoferenza());
            Console.WriteLine("Il valore dell'area e': {0}", c.CalcoloArea());
        }
    }
}
