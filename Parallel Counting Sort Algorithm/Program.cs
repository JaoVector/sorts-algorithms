internal class Program
{
    public static void CountingSort(int[] array, int size, int exp)
    {

        int[] output = new int[size];
        int[] occurrences = new int[10];

        for (int i = 0; i < size; i++)
        {
            occurrences[array[i] / exp % 10]++;
        }

        
        for (int i = 1; i < 10; i++)
        {
            occurrences[i] += occurrences[i - 1];   
        }
        

        for (int i = size - 1; i >= 0; i--)
        {
            output[occurrences[array[i] / exp % 10] - 1] = array[i];
            occurrences[array[i] / exp % 10]--;
        }
        
        for (int i = 0; i < size; i++)
        {
            array[i] = output[i];
        }
    }

    public static void ParallelCounting(int[] array, int size)
    {
        var maxValue = array.Max();

        for (int exp = 1; maxValue / exp > 0; exp *= 10)
        {
            for (int i = 0; i < size; i++)
            {
                CountingSort(array, size, exp);
            }
        }
    }

    private static void Main(string[] args)
    {
       int[] unsorted = [ 4, 3, 12, 1, 5, 5, 3, 9 ];

        ParallelCounting(unsorted, unsorted.Length);

        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
    }
}