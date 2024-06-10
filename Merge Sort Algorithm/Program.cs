
internal class Program
{
    public static void Merge(int[] array, int left, int right, int middle)
    {
        var leftArrayLength = middle - left + 1;
        var rightArrayLength = right - middle;
        var leftTempArray = new int[leftArrayLength];
        var rightTempArray = new int[rightArrayLength];
        int i, j;

        for (i = 0; i < leftArrayLength; i++)
        {
            leftTempArray[i] = array[left + i];
        }

        for (j = 0; j < rightArrayLength; j++)
        {
            rightTempArray[j] = array[middle + 1 + j];
        }

        i = 0;
        j = 0;

        int k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if(leftTempArray[i] <= rightTempArray[j])
            {
                array[k++] = leftTempArray[i++];
            } else 
            {
                array[k++] = rightTempArray[j++];
            }
        }

        while (i < leftArrayLength)
        {
            array[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength)
        {
            array[k++] = rightTempArray[j++];
        }
    }
    public static int[] Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            Sort(array, left, middle);
            Sort(array, middle + 1, right);

            Merge(array, left, right, middle);
        }

        return array;
    }

    public static void Main(string[] args)
    {
       int[] array = [38, 27, 43, 3, 9, 82, 10, 2];

       var sortedArray = Sort(array, 0, array.Length - 1);

       for (int i = 0; i < sortedArray.Length; i++)
       {
          Console.WriteLine(sortedArray[i]);
       }
    }
}