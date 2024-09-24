using System.ComponentModel.DataAnnotations;

namespace Ejercicios_5;

class Program
{
    static void Main(string[] args)
    {
//------1--------------------------------------------------------------------------------------------
        // for (int i = 0; i <= 10; i++){
        //     Console.WriteLine("numero " + i);
        // }


//------2--------------------------------------------------------------------------------------------
        // int n, max;

        // Console.WriteLine("ingrese un numero: ");
        // max = int.Parse(Console.ReadLine());        

        // for (int i = 0; i < 9; i++)
        // {
        //     Console.WriteLine("ingrese un numero: ");
        //     n = int.Parse(Console.ReadLine());

        //     if(n>max){
        //         max=n;
        //     }
        // }
        // Console.WriteLine("el maximo es "+max);


//------3--------------------------------------------------------------------------------------------
        // Hacer un programa que solicite 20 edades y 
        //luego calcule el promedio de edad de aquellas personas mayores a 18 años.
        
        // int edad, cont = 0, acum = 0;

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("Escriba la edad: ");
        //     edad = int.Parse(Console.ReadLine());
            
        //     if (edad > 18){
        //         cont++;
        //         acum+=edad;
        //     }
        // }
        // Console.WriteLine("El promedio de los mayores a 18 es de: " + (acum/cont));

//------4--------------------------------------------------------------------------------------------

        // Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio 
        // si el mismo es primo o no es primo.

        // int primo, con = 0;

        // Console.WriteLine("ingrese un numero: ");
        // primo = int.Parse(Console.ReadLine());

        // for (int i = 2; i < primo; i++)
        // {
        //     if (primo % i == 0)
        //         con++;
        // }
        // if(con == 0){
        //     Console.WriteLine("El numero ingresado es primo");
        // }else
        //     Console.WriteLine("El numero ingresado NO es primo");
        
// ------5--------------------------------------------------------------------------------------------
//         Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo 
//         de los números pares y el mínimo de los números impares.

        int n, max = 0, min = 0;
        int contPar = 0, contImpar = 0;
        bool banPar = false, banImpar = false;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            
            if(n % 2 ==0){

                //contPar++;
                if(banPar == false){
                        max = n;
                        banPar = true;
                }else if(n>max){
                        max=n;
                }
            }else if{
                //contImpar++;
                if(banImpar == false){}
                        min = n;
                        banImpar = true;
                }else if(n<min){
                        min=n;
                }
            }
        }
        Console.WriteLine("El maximo par es: " + max);
        Console.WriteLine("El minimo par es: " + min);
    }
}
