
int[] array = [3, 5, 8, 4, 1, 9, -2];

int tam = array.Length;

for (int i = 0; i < tam - 1; i++)
{
    for (int j = 0; j < tam - i - 1; j++)
    {
        if(array[j] > array[j + 1])
        {
            var aux = array[j];
            array[j] = array[j + 1];
            array[j + 1] = aux;
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);   
}