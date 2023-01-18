using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class ClassNumero
    {
        int cEstu;
        int num, suma;

        public int Num { get; set; }  
        public int CEstu { get; set; }
        public int Suma { get { return num; } set { num = value; } }

        //public int Aprobado(int num)
        //{
        //    return 
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

        public void Estado(int Suma)
        {
            if (Suma > 59)
            {
                Console.WriteLine("El estudinate está aprobado");
            }
            else
            {
                Console.WriteLine("El estudiante esta reprobado");
            }
        }
    }
}
