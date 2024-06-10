internal class Program
{

    public static void SortBinary(int[] array)
    {
        int k = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == 1)
            {
                array[i] = 0;
                k++;
            }

        }

        for (int i = k; i < array.Length; i++)
        {
            array[i] = 1;
        }
    }

    private static void Main(string[] args)
    {
        int[] array = [1, 0, 1, 0, 1, 0, 0, 1];

        SortBinary(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
}