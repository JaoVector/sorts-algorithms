internal class Program
{
    public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        int i = leftIndex;
        int j = rightIndex;
        int pivot = array[leftIndex];

        while (i <= j) 
        {
            while(array[i] < pivot)
            {
                i++;
            }

            while(array[j] > pivot)
            {
                j--;
            }

            if(i <= j)
            {
                (array[j], array[i]) = (array[i], array[j]);
                i++;
                j--;
            }
        }

        if(leftIndex < j)
            QuickSort(array, leftIndex, j);

        if(i < rightIndex)
            QuickSort(array, i, rightIndex);

       return array; 
    }

    public static void Main(string[] args)
    {
        int[] unsorted = [10, 2, 8, 1, 4, 6, 3, 5, 7, 9];

        var sorted = QuickSort(unsorted, 0, unsorted.Length - 1);

        for (int i = 0; i < sorted.Length; i++)
        {
            Console.Write(sorted[i] + " ");
        }
    }
}