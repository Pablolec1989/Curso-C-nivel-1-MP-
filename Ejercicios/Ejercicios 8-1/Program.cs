namespace Ejercicios_8;

class Program
{
    static void Main(string[] args)
    {
        //Declaracion de variables
        int n1=0, n2=0, producto;
        
        //Llamado de funcion 'pedir datos'
        Pedirdatos(ref n1, ref n2);
        
        //Llamado de funcion 'producto' y el return lo guardo en la variable.
        producto = Producto(ref n1, ref n2);
        Console.WriteLine("El producto de " + n1 + " x "+ n2 + " es igual a: " + producto);
    }

    // FUNCIONES (Fuera del Main)
    // Funcion pedir datos:    
    static void Pedirdatos(ref int n1, ref int n2){
        Console.WriteLine("Ingrese el primer numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2 = int.Parse(Console.ReadLine());
        }
    
    // Funcion producto
    static int Producto(ref int n1, ref int n2){
        return n1*n2;
        }
}