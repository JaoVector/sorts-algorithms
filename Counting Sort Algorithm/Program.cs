internal class Program
{
    private static int[] CountingSort(int[] array)
    {
        int n = array.Length;
        int maxValue = array.Max();
        int[] ocurrences = new int[maxValue + 1];

        for (int i = 0; i < maxValue + 1; i++)
        {
            ocurrences[i] = 0;
        }

        for (int i = 0; i < n; i++)
        {
            ocurrences[array[i]]++;
        }

        for (int i = 0, j = 0; i <= maxValue; i++)
        {
            while(ocurrences[i] > 0)
            {
                array[j] = i;
                j++;
                ocurrences[i]--;
            }
        }

        return array;
    }

    private static void Main(string[] args)
    {
        int[] unsorted = [ 4, 3, 12, 1, 5, 5, 3, 9 ];

        var sorted = CountingSort(unsorted);

        for (int i = 0; i < sorted.Length; i++)
        {
            Console.Write(sorted[i] + " ");
        }
    }
}

/*
public static List<int> CountingSort(List<int> inputArray)
    {
        int size = inputArray.Count;
        int maxValue = 0;

        for (int i = 0; i < size; i++)
        {
            maxValue = Math.Max(maxValue, inputArray[i]);
        }

        var countArray = new List<int>(new int[maxValue + 1]);

        for (int i = 0; i < size; i++)
        {
            countArray[inputArray[i]]++;
        }

        for(int i = 1; i <= maxValue; i++)
        {
            countArray[i] += countArray[i - 1];
        }

        var outputArray = new List<int>(new int[size]);

        for (int i = size - 1; i >= 0; i--)
        {
            outputArray[countArray[inputArray[i]] - 1] = inputArray[i];
            countArray[inputArray[i]]--;
        }
        return outputArray;
    }

    private static void Main(string[] args)
    {
        var unsorted = new List<int> { 4, 3, 12, 1, 5, 5, 3, 9 };

        var sorted = CountingSort(unsorted);

        for (int i = 0; i < sorted.Count; i++)
        {
            Console.Write(sorted[i] + " ");
        }
    }
*/