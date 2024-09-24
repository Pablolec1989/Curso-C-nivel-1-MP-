namespace Ejercicios_2;

class Program
{
    static void Main(string[] args)
    {
        //--1------------------------------------------------------------------------------------------
        // int a,b,resultado;

        // Console.WriteLine("Ingrese el primer numero");
        // a = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese el segundo numero");
        // b = int.Parse(Console.ReadLine());

        // Console.WriteLine("La suma de a + b es igual a; " + (a+b));

        //--2------------------------------------------------------------------------------------------
        // int c;

        // Console.WriteLine("Ingrese el numero");
        // c = int.Parse(Console.ReadLine());
        // Console.WriteLine("El numero elevado al cubo es:" + (c*c*c));

        //--3------------------------------------------------------------------------------------------
        // int dist, vel, t;

        // Console.WriteLine("Ingrese la distancia: ");
        // dist = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese la velocidad: ");
        // vel = int.Parse(Console.ReadLine());

        // Console.WriteLine("Tardarás " + (dist/vel) + " minutos en llegar");


        //--4------------------------------------------------------------------------------------------

        // int fact;

        // Console.WriteLine("Ingrese facturacion: ");
        // fact = int.Parse(Console.ReadLine());

        // Console.WriteLine("Tu sueldo sera de $ "+ (15000 + (fact*0.05)));

        //--5------------------------------------------------------------------------------------------

        int n1,n2,n3;

        Console.WriteLine("Ingrese nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Tu promedio es de: "+ ((n1+n2+n3)/3));


    }
}
