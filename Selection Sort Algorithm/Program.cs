
int[] array = [3, 5, 8, 4, 1, 9,-2];

int n = array.Length;

for (int i = 0; i < n - 1; i++)
{
    int indexMenor = i;
    for (int j = i + 1; j < n; j++)
    {
        if(array[j] < array[indexMenor])
        {
            indexMenor = j;
        }
    }

    int menor = array[indexMenor];
    array[indexMenor] = array[i];
    array[i] = menor;
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}