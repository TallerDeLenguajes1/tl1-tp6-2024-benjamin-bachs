// See https://aka.ms/new-console-template for more information

Console.WriteLine("CALCULADORA V1\n");
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
    int a = 0, b = 0;
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

static bool tomarNumeros(ref int a, ref int b){
    Console.WriteLine("\nIngrese los dos numeros a operar:");
                String aString, bString;
                aString = Console.ReadLine();
                bString = Console.ReadLine();
                if(int.TryParse(aString, out a) && int.TryParse(bString, out b )) return true;
                else {
                    Console.WriteLine("\nDebe ingresar numeros\n");
                    return false;
                }
}