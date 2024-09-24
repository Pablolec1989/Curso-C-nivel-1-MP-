namespace Ejercicios_7;

class Program
{
    static void Main(string[] args)
    {

// ------1---------------------------------------------------------------------------------------------
        // int [] numeros = new int [10];

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("ingrese un numero: "); // pido el dato
        //     numeros[i] = int.Parse(Console.ReadLine()); // guardo el valor en la posicion actual del bucle.
        // }

        // int max = numeros[0]; // supongo que el max es el primer dato del array
        // int pos = 1;

        // for (int i = 0; i < 10; i++)
        // {
        //     if (numeros[i] > max){ 
        //         max = numeros[i];
        //         pos = i+1;
        //     }
        // }
        // Console.WriteLine("El mayor valor es: " + max);

// ------2---------------------------------------------------------------------------------------------

        // int [] numeros = new int [10];

        //  for (int i = 0; i < 10; i++)
        //  {
        //     Console.WriteLine("ingrese un numero: "); // pido el dato
        //     numeros[i] = int.Parse(Console.ReadLine()); // guardo el valor en la posicion actual del bucle.
        //  }

        //  int acum = 0;

        //  for (int i = 0; i < 10; i++)
        //  {
        //     numeros[i] = acum;
        //  }

        //  int promedio = acum/10; //calculo el promedio

        //  for (int i = 0; i < 10; i++)
        //  {
        //     if (numeros[i]>promedio){
        //         Console.WriteLine("numero mayor a promedio es el:" + numeros[i]);
        //     }
        //  }

// ------3---------------------------------------------------------------------------------------------
        // char[] frase = new char[30];
        // char letra1;
        // char letra2;
        // int indice = 0;
        // char letra;

        // Console.WriteLine("ingrese una letra para la frase: ");
        // letra = char.Parse(Console.ReadLine());

        // while(letra != '0' && indice < 30){  // con '0' cancelo el bucle y el indice no se pase del tamaño del array.

        //     frase[indice] = letra; //asigno el dato de letra en frase, posicion indice
        //     Console.WriteLine("ingrese otra letra: "); // solicito el dato
        //     letra = char.Parse(Console.ReadLine()); // asigno el dato a la variable 'letra'
        //     indice++; //modifico el indice
        // }
        // frase[indice] = '\0'; // defino el final de la cadena con '\0'
        // Console.WriteLine("La frase completa es: ");
        // indice = 0;

        // while(frase [indice] != '\0') //recorro el array de caracteres teniendo en cuenta que termina antes de '\0'
        // { 
        //     Console.Write(frase[indice]);
        //     indice++;
        // }
        
        // Console.WriteLine("Ingrese la letra a reemplazar: ");
        // letra1 = char.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese la letra nueva: ");
        // letra2 = char.Parse(Console.ReadLine());


        // indice = 0;
        // while(frase[indice] !='\0') // reemplazo la letra actual con la letra nueva
        // {
        //     if(frase[indice] == letra1)
                    
        //         frase[indice] = letra2; 
        //     indice++;
        // }

        // Console.WriteLine("Frase nueva: ");
        // indice = 0;

        // while(frase[indice] !='\0')
        // {
        //     Console.Write(frase[indice]);
        //     indice++;
        // }




// ------4---------------------------------------------------------------------------------------------
        // https://www.youtube.com/watch?v=_8BG8TKj1Ss

        // REGISTROS.(datos relacionados)

        int nroArticulo;
        int cantidad;

        // en cada uno de los 15 elementos voy a acumular cantidades en cada casilla.
        int[] totalCantVend = new int[15];
        
        // Inicializo en 0 todos los elementos del array para contar.
        for (int i = 0; i < 15; i++)
        {
            totalCantVend[i] = 0;
        }

        // pido datos afuera del bucle
        Console.WriteLine("ingrese el nro de articulo: ");
        nroArticulo = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la cantidad vendida: ");
        cantidad = int.Parse(Console.ReadLine());

        // vuelvo a pedir datos pero con una condicion de corte.
        while(nroArticulo !=0){
            // cuando la persona cargue el producto 1, se acumula en el indice 0 del array.
            // Quiero cargar la cantidad en el articulo-1 que lo uso como indice de referencia en mi array.
            totalCantVend[nroArticulo -1] += cantidad;

            Console.WriteLine("ingrese el nro de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());
        }

        // punto a. El número de artículo que más se vendió en total.

        int max = totalCantVend[0]; //asumo que el primer dato de cantidad es el maximo
        int nroMaximo = 1;

        for (int i = 0; i < 15; i++)
        {
            if(totalCantVend[i]>max){
                max = totalCantVend[i];
                nroMaximo = i + 1;
            }
        }
        Console.WriteLine("El producto mas vendido es el :" + nroArticulo +"con una cantidad de: " + max);

        // punto b. Los números de artículos que no registraron ventas.

        for (int i = 0; i < 15; i++)
        {
            if(totalCantVend[i] == 0){
                Console.WriteLine("El producto " + (i + 1) + "no tuvo ventas");
            }
        }

        // punto c. Cuantas unidades se vendieron del art 10.

        Console.WriteLine("la cantidad vendida del art 10 es de: "+ totalCantVend[9]);
    }
}
