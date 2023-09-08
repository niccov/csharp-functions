// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 6, 7, 5, 3, 9 };

//Stampare l’array di numeri fornito a video
Console.WriteLine("array stampato");

PrintArray(numbers);

Console.WriteLine();


//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Console.WriteLine("array elevato al quadrato stampato");

PrintArray(ElevaArrayAlQuadrato(numbers));

Console.WriteLine();

Console.WriteLine("controllo dell'array stampato");
PrintArray(numbers);

Console.WriteLine();

//Stampare la somma di tutti i numeri

Console.WriteLine("somma di tutti i numeri dell'array");
Console.WriteLine(SommaElementiArray(numbers));

Console.WriteLine();

//Stampare la somma di tutti i numeri elevati al quadrati

Console.WriteLine("somma di tutti i numeri dell'array al quadrato");

Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(numbers)));

Console.WriteLine();
//funzione che stampa un array

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");

}

Console.WriteLine();

//funzione che restituisce il quadrato del numero passato come parametro

    int Quadrato(int number)
    {
        return (number * number);
    }


Console.WriteLine();

//funzione che preso un array restituisce lo stesso array copiato con tutti gli elementi elevati al quadrato

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copia = (int[])array.Clone();

    for (int i = 0; i < copia.Length; i++)
    {
        copia[i] = Quadrato(copia[i]);
    }

    return copia;
}



Console.WriteLine();

//funzione che preso un array di numeri interi restituisce un intero che sarebbe la somma di tutti gli elementi dell'array

    int SommaElementiArray(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

