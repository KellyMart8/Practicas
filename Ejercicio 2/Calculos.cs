using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Calculos
    {
        int op;
        float l, b, h;

        public int Op { get; set; }
        public float L { get; set; }
        public float B { get; set; }
        public float H { get; set; }

        public float aTrinagulo()
        {
            return (B * H) / 2;
        }

        public float aRectrangulo()
        {
            return B * H;
        }

        public float aCuadrado()
        {
            return L * L;
        }

        //public int Menu(int Op)
        //{
        //    Console.WriteLine("Seleccione una opcion");
        //    Console.WriteLine("1. Area del trinagulo");
        //    Console.WriteLine("2. Area del rectangulo");
        //    Console.WriteLine("3. Area del cuadrado");
        //    Console.WriteLine("4. Salir");
        //}

        public int Validar(string Mensaje)
        {
            int Num = 0, v;

            do
            {
                v = 1;

                try
                {
                    Console.Write(Mensaje);
                    Num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;

                    Console.WriteLine(" (X) Se produjo el siguiente error: {0}", error.Message);
                }


            } while (v == 0);

            return Num;
        }

    }
}
