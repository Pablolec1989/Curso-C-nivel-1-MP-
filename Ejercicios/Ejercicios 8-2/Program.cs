namespace Ejercicios_8_2;

class Program
{
    static void Main(string[] args)
    {
        // Defino variables a utilizar en mi programa
        int n=0;

        // Solicito dato al usuario:
        Console.WriteLine("Ingrese un numero...");
        n = int.Parse(Console.ReadLine());

        // llamado de funcion Par:
        Console.WriteLine(n + " es par? " + Par(n));

// ------------------------------------------2da PARTE--------------------------------------------------------
        
        int a = 0, cont = 0;
        
        for (int i = 0; i < 5; i++){
            Console.WriteLine("Ingrese un numero...");
            a = int.Parse(Console.ReadLine());
            if (Par(a)){
                cont++;
            }
        }
        Console.WriteLine("La cantidad de valores pares es: " + cont);


    }

    // Funcion PAR, devuelve valor bool (true/false).
    static bool Par(int n){
        if(n % 2 == 0){
            return true;
        }else{
            return false;
        }
    }
}
