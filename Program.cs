using System;

namespace Domino
{
    class Pieza
    {
        public int arriba;
        public int abajo;

        public Pieza(int arr, int aba)
        {
            arriba=arr;
            abajo=aba;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", arriba, abajo);
        }
        public static Pieza operator +(Pieza x, Pieza y)
        {
            int arriba=(x.arriba+x.abajo+y.arriba+y.abajo);
            int abajo=(1);
            return new Pieza(arriba, abajo);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pieza a= new Pieza(2,5);
            Pieza b= new Pieza(1,6);
            Pieza C=a+b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(C);            
        }
    }
}
