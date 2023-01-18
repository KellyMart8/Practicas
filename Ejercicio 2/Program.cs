using Ejercicio_2;

Calculos c = new Calculos();

Console.WriteLine("Bienvenido");
do
{
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("1. Area del trinagulo");
    Console.WriteLine("2. Area del rectangulo");
    Console.WriteLine("3. Area del cuadrado");
    Console.WriteLine("4. Salir");
    c.Op = c.Validar("ingrese una de las opciones ");

}while (c.Op <1 || c.Op >4);

switch (c.Op)
{
    case 1:
        Console.WriteLine("ingrese la base ");
        c.B = c.Validar("Ingrese un numero ");

        Console.WriteLine("Digite la altura ");
        c.H = c.Validar("Ingrese un numero ");

        Console.WriteLine("El area del triangulo es: " + c.aTrinagulo);
        break;

    case 2:
        Console.WriteLine("ingrese la base ");
        c.B = c.Validar("Ingrese un numero ");

        Console.WriteLine("Digite la altura ");
        c.H = c.Validar("Ingrese un numero ");

        Console.WriteLine("El area del rectangulo es: " + c.aRectrangulo);
        break;

    case 3:
        Console.WriteLine("Digite el lado ");
        c.L = c.Validar("Ingrese un numero ");

        Console.WriteLine("El area del cuadrado es: " + c.aCuadrado);
        break;

    case 4: break;

}