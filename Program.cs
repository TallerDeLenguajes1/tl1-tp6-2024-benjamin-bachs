// See https://aka.ms/new-console-template for more information

Console.WriteLine("CALCULADORA V2\n");
Console.Write("Ingrese un numero:");
string n = Console.ReadLine();
float a = 0;
if (float.TryParse(n, out a)){
    Console.WriteLine($"Valor absoluto: {Math.Abs(a)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(a, 2)}");
    Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(a)}");
    Console.WriteLine($"Seno: {Math.Sin(a)}");
    Console.WriteLine($"Coseno: {Math.Cos(a)}");
    Console.WriteLine($"Parte entera: {(int)a}");
} else {
    Console.WriteLine("No fue ingresado un numero valido");
}
int b=0, c=0;
Console.Write("Maximo y minimo:");
if(tomarNumeros(ref b, ref c)){
    Console.WriteLine($"Maximo: {Math.Max(a, b)}");
    Console.WriteLine($"Minimo: {Math.Min(a, b)}");
}



static bool tomarNumeros(ref int a, ref int b){
    Console.WriteLine("\nIngrese los dos numeros a operar:");
                String aString, bString;
                aString = Console.ReadLine();
                bString = Console.ReadLine();
                if(int.TryParse(aString, out a) && int.TryParse(bString, out b )) return true;
                else {
                    Console.WriteLine("\nNo fueron ingresados numeros validos\n");
                    return false;
                }
}