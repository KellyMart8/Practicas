using ejercicio1;
using System;

ClassNumero cn = new ClassNumero();
int suma = 0, a;

do
{
    cn.CEstu = cn.Validar("Ingrese la cantidad de estudiantes ");

} while (cn.CEstu < 1 || cn.CEstu > 24);

for (int i = 0; i < cn.CEstu; i++)
    {
        suma = 0;
        Console.WriteLine("Estudiante #" + (i + 1));

        for (int j = 0; j < 4; j++)  //Ingresa la 4 notas
        {

            do
            {
                cn.Num = cn.Validar("Ingresa la " + (j + 1) + "° nota en el rango de 0 a 25: ");
                suma += cn.Num;
                a = suma;
                break;

            } while (cn.Num < 1 || cn.Num > 25);
            Console.WriteLine("Sumatoria con la nota anterior " + a);

        }


        if (suma < 60)
        {
            Console.WriteLine("REPROBADO");
        }
        else Console.WriteLine("APROBADO");
    }




