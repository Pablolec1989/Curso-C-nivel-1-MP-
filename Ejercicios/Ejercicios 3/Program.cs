namespace Ejercicios_3;

class Program
{
    static void Main(string[] args)
    {
// ------1----------------------------------------------------------------------------------------------    
        // int a;

        // Console.WriteLine("ingresa un numero: ");
        // a = int.Parse(Console.ReadLine());

        // if(a > 10){
        //     Console.WriteLine(a + " es mayor a 10");
        // }else{
        //     Console.WriteLine(a + " es menor a 10");
        // }


// ------2----------------------------------------------------------------------------------------------
        // int b;

        // Console.WriteLine("ingresa un numero: ");
        // b = int.Parse(Console.ReadLine());

        // if(b>0){
        //     Console.WriteLine("el numero es MAYOR a cero");
        //     }
        // else if (b<0)
        // {
        //     Console.WriteLine("el numero es MENOR a cero");
        // }else{
        //     Console.WriteLine("el numero es IGUAL a cero");
        // }


// ------3----------------------------------------------------------------------------------------------

        // int compra;
        
        // Console.WriteLine("ingresa importe: ");
        // compra = int.Parse(Console.ReadLine());

        // if (compra > 5000){
        //     Console.WriteLine("Importe final a pagar con desc. del 18%: "+ (compra-(compra*0.18)));
        // }else if(compra>=1000 && compra <5000){
        //     Console.WriteLine("Importe final a pagar con desc. del 10%: "+ (compra-(compra*0.10)));
        // }else{
        //     Console.WriteLine("No hay descuento");
        // }

// ------4----------------------------------------------------------------------------------------------

        // int c,d,e,f;

        // Console.WriteLine("Ingrese el primer numero: ");
        // c = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese el segundo numero: ");
        // d = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese el tercero numero: ");
        // e = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese el cuerto numero: ");
        // f = int.Parse(Console.ReadLine());

        // if (c>d && c>e && c>f){
        //     Console.WriteLine(c + " es el mayor");
        // }else if(d>c && d>f && d>e){
        //     Console.WriteLine(d + " es el mayor");
        // }else if(e>c && e>d && e>f){
        //     Console.WriteLine(e + " es el mayor");
        // }else{
        //     Console.WriteLine(f + " es el mayor");
        // }

// ------5----------------------------------------------------------------------------------------------

         int g,h,i,j;

        Console.WriteLine("Ingrese el primer numero: ");
        g = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        
        h = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero: ");
        i = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el cuerto numero: ");
        j = int.Parse(Console.ReadLine());

        if(g>100)
            Console.WriteLine(g + " es mayor a 100");
            
        if(h>100)
            Console.WriteLine(h + " es mayor a 100");

        if(i>100)
            Console.Write(i + " es mayor a 100");

        if(j>100)
            Console.WriteLine(j + " es mayor a 100");

    }
}
