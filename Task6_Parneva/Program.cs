using System;

namespace Task6_Parneva
{
    class Program
    
    {
        public static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        public static void PrintIndexable(IIndexable indexable, int count)
        {
            for (int i = 1; i <= count; i++)
            {      
                Console.WriteLine(indexable[i]);
            }
        }
        static void Main(string[] args)
        { 

            ArithmeticProgression arithmetic = new ArithmeticProgression(1,5);
           
            GeometricProgression geometric = new GeometricProgression(2,5);

            PrintSeries(arithmetic,3);
            PrintIndexable(arithmetic, 3);
            Console.WriteLine();
            PrintSeries(geometric, 3);
            PrintIndexable(geometric, 3);
        }
    }
}
