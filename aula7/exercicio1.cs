int[] numeros =  new int[11];
numeros = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11};

for(int i = 0; i<11 ; i++)
{
    System.Console.WriteLine(numeros[i]);
    if(numeros[i] % 2 == 0)
    {
        System.Console.WriteLine(numeros[i]);
        int[] pares = [numeros[i]];
    }
    if(numeros[i] % 2 == 1)
    {
        System.Console.WriteLine(numeros[i]);
        int[] impares = [numeros[i]];

    }
}