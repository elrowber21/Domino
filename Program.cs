using System;

namespace Dom
{
    //Implementación de la clase Domino
    class Domino
    {
        //Atributos de la clase Domino
        public int Espacio1;
        public int Espacio2;

        // Constructor para la clase Domino 
        public Domino(int E1, int E2)
        {
            Espacio1=E1;
            Espacio2=E2;
        }
        // Definición de resultado para sobrecarga
        public override string ToString()
        {
            return String.Format("{0}/{1}", Espacio1, Espacio2);
        }
        //Creación para operador +
        public static Domino operator +(Domino x, Domino y)
        {
            int Espacio1=(x.Espacio1+x.Espacio2+y.Espacio1+y.Espacio2);
            int Espacio2=(1);
            return new Domino(Espacio1, Espacio2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Construcciones de objetos
            Domino a= new Domino(2,5);
            Domino b= new Domino(1,6);
            //Función de operación
            Domino C=a+b;
            //Impresiones
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(C);            
        }
    }
}

