class exercicio1
{
    static void Main(string[] args)
    {
      int[] numeros =  new int[10];
     numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
     int[] pares =  new int[10];
     int[] impares = new int[10];
    for(int i = 0; i<11 ; i++)
     {
    System.Console.WriteLine(numeros[i]);
    if(numeros[i] % 2 == 0)
    {
        System.Console.WriteLine(numeros[i]);
        pares = [numeros[i]];
    }
    if(numeros[i] % 2 == 1)
    {
        System.Console.WriteLine(numeros[i]);
        impares = [numeros[i]];

    }
    }
     }
    }
