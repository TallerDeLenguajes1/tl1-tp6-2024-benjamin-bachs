// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

Console.WriteLine("CALCULADORA V1\n");
float a = 0, b = 0;
for (int i = 0; i < 10000; i++)
{
    Console.WriteLine("Elija la opcion deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Diferencia");
    Console.WriteLine("3. Producto");
    Console.WriteLine("4. Cociente");
    Console.WriteLine("Ingrese otra cosa para salir\n");
    Console.Write("Opcion: ");
    String opcion;
    opcion = Console.ReadLine();
    
        switch (opcion)
        {
            case "1":
                if(tomarNumeros(ref a, ref b)) Console.WriteLine($"\nResultado: {a+b}\n");
                continue;
            case "2":
                if(tomarNumeros(ref a, ref b)) Console.WriteLine($"\nResultado: {a-b}\n");
                continue;
            case "3":
                if(tomarNumeros(ref a, ref b)) Console.WriteLine($"\nResultado: {a*b}\n");
                continue;
            case "4":
                if(tomarNumeros(ref a, ref b) && b != 0) Console.WriteLine($"Resultado: {a/b}\n");
                else if(b!=0) Console.WriteLine("No se puede dividir por 0\n");
                continue;
            default:
                break;
        }
        break;
}

Console.WriteLine("\nCALCULADORA V2");
Console.Write("Ingrese un numero: ");
string n = Console.ReadLine();
if (float.TryParse(n, out a)){
    Console.WriteLine($"\nValor absoluto: {Math.Abs(a)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(a, 2)}");
    Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(a)}");
    Console.WriteLine($"Seno: {Math.Sin(a)}");
    Console.WriteLine($"Coseno: {Math.Cos(a)}");
    Console.WriteLine($"Parte entera: {(int)a}");
} else {
    Console.WriteLine("No fue ingresado un numero valido");
}
Console.Write("\nMaximo y minimo");
if(tomarNumeros(ref a, ref b)){
    Console.WriteLine($"\nMaximo: {Math.Max(a, b)}");
    Console.WriteLine($"Minimo: {Math.Min(a, b)}");
}



static bool tomarNumeros(ref float a, ref float b){
    Console.WriteLine("\nIngrese los dos numeros a operar:");
                String aString, bString;
                aString = Console.ReadLine();
                bString = Console.ReadLine();
                if(float.TryParse(aString, out a) && float.TryParse(bString, out b )) return true;
                else {
                    Console.WriteLine("\nNo fueron ingresados numeros validos\n");
                    return false;
                }
}