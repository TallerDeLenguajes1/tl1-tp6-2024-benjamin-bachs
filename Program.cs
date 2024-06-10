// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Ingrese un numero para ser invertido: ");
string entrada = Console.ReadLine();
int convertido;

if(int.TryParse(entrada, out convertido) && convertido>0){
    int aux = 0;
    while (convertido != 0)
    {
        aux=aux*10+convertido%10;
        convertido/=10;
    }
    Console.WriteLine($"Numero invertido: {aux}");
}