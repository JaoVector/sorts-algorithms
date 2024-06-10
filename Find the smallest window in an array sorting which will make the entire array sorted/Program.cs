internal class Program
{

    public static int[] FindIndexSmallWindow(int[] array)
    {

        int maxValue = Int32.MinValue;
        int minValue = Int32.MaxValue;
        int i = -1, j = -1; 

        for (int left = 0; left < array.Length; left++)
        {
            if(maxValue < array[left])
            {
                maxValue = array[left];
            }

            if(array[left] < maxValue)
            {
                i = left;
            }
        }

        for (int right = array.Length - 1; right >= 0; right--)
        {
            if(minValue > array[right])
            {
                minValue = array[right];
            }

            if(array[right] > minValue)
            {
                j = right;
            }
        }

        return [i, j];
    }

    private static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 7, 5, 6, 4, 8];

        var index = FindIndexSmallWindow(array);

        Console.WriteLine("I: " + index[0] + " " + "J: " + index[1]);

    }
}