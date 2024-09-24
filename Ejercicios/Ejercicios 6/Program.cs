namespace Ejercicios_6;

class Program
{
    static void Main(string[] args)
    {
//------1--------------------------------------------------------------------------------------------
        // for (int i = 1; i < 11; i++) //bucle principal
        // {
        //     for (int j = 1; j < 11; j++) //bucle secundario
        //     {
        //         int primo, cont = 0;
                
        //         Console.WriteLine("ingrese un numero: ");
        //         primo = int.Parse(Console.ReadLine());
        //         // Evaluo 
        //         for (int k = 2; k < primo; k++){
        //             if (primo % k == 0)
        //             cont++;
        //             }
        //         // veo cuantos fueron los numeros.
        //             if(cont == 0){
        //                 Console.WriteLine("El numero ingresado ES primo");
        //             }else
        //                 Console.WriteLine("El numero ingresado NO es primo");
        //     }
        // }

//------2--------------------------------------------------------------------------------------------
        // int n = 0; int grupoImparesMaximo = 0;
        // double porcentajeImpares = 0; 
        // double porcentajeMaximo = -1;
        // int min = 0; // parte 2
        // bool banderaOrdenados = true; // Parte 2.
        // int contOrdenados = 0;

        // for (int i = 0; i < 5; i++){
        //     int conNros = 0;  //Inicializo el contador para cada grupo
        //     int conImpar = 0;

        //     Console.WriteLine("ingrese un numero: ");
        //     n = int.Parse(Console.ReadLine());
        //     min = n;
            
        //     while(n !=0){
        //         conNros++;

        //         if(n % 2 !=0)
        //             conImpar++;
                
        //         //Parte 2.
        //         if(n <= min) 
        //             min = n;
        //         else
        //             banderaOrdenados = false;
                
        //         Console.WriteLine("ingrese un numero: ");
        //         n = int.Parse(Console.ReadLine());
        //     }
        //     // Parte 1. El numero de grupo mayor porcentaje de impares respecto al total de numeros
        //     // que forman el grupo.
        //     porcentajeImpares = conImpar*100/conNros;

        //     if (porcentajeImpares > porcentajeMaximo){
        //         porcentajeMaximo = porcentajeImpares;
        //         grupoImparesMaximo = i + 1;
        //     }

        //     // Parte 2. Informar cuantos grupos estan formados por todos los numeros ordenados de may a men.
        //     // defino una variable como minimo antes del while.
        //     if(banderaOrdenados){
        //         contOrdenados++;
        //     }
        // } // fin del FOR

        // Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
        // Console.WriteLine("La cantidad de grupos con nros ordenados es: " + contOrdenados);


//------3-------------------------------------------------------------------------------------------- 
        int lista, con;

        do
        {
            con = 0;
            Console.WriteLine("ingrese un numero");
            lista = int.Parse(Console.ReadLine());
            while(lista > 0){
                con++;

                Console.WriteLine("ingrese un numero");
                lista = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad es: " + con);

        }while(lista >= 0); //Condicion para saber si inicia denuevo el bucle 'do'
    }
}
