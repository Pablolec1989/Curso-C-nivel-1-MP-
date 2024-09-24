namespace Ejercicios_8_4;

class Program
{
    static void Main(string[] args)
    {
        int numero, status = 9;

        //USUARIO

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());


        PositivoNegativoCero(numero, ref status);

        Console.WriteLine("El estado del valor " + numero + " es: " + status);
    }

    //FUNCIONES
    static void PositivoNegativoCero(int n, ref int estado){
        if(n>0)
            estado = 1;
        else if(n==0)
            estado= 0;
        else
            estado = -1;

        n = 10;
    }
}
