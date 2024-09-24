using System.Security.AccessControl;

namespace Ejercicios_8_3;

class Program
{
    static void Main(string[] args)
    {
        int n = 0, acum= 0, conPrimos = 0;

    //USUARIO

    Console.WriteLine("ingrese numeros: ");
    n = int.Parse(Console.ReadLine());
    
    while(n !=0){
        Console.WriteLine("ingrese numeros: ");
        n = int.Parse(Console.ReadLine());
        // Si es primo lo cuento y acumulo.
        if(Primo(n)){
            conPrimos++;
            acum += n;
            }
        }
        Console.WriteLine("El promedio de numeros primos es de: " + (acum/conPrimos));
    }

    // FUNCIONES

    // Funcion Primo. Devuelve bool.
    static bool Primo(int n){
        int con = 0;
        for (int i = 1; i <= n; i++){
            if (n % i == 0)
                con++;
        }
        if(con == 2){
            return true;
        }else{
            return false;
        }
    }
}
