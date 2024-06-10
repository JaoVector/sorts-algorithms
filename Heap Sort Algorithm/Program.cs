internal class Program
{
    public static int[] HeapSort(int[] array, int size)
    {
        if(size <= 1)
        {
            return array;
        }

        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapfy(array, size, i);
        }

        for (int i = size - 1; i >= 0; i--)
        {
            var aux = array[0];
            array[0] = array[i];
            array[i] = aux;

            Heapfy(array, i, 0);
        }

        return array;
    }

    public static void Heapfy(int[] array, int size, int index)
    {
        var indexMaxElement = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        if(leftChild < size && array[leftChild] > array[indexMaxElement])
        {
            indexMaxElement = leftChild;
        }

        if(rightChild < size && array[rightChild] > array[indexMaxElement])
        {
            indexMaxElement = rightChild;
        } 

        if(indexMaxElement != index)
        {
            var aux = array[index];
            array[index] = array[indexMaxElement];
            array[indexMaxElement] = aux;

            Heapfy(array, size, indexMaxElement);
        }
    }

    private static void Main(string[] args)
    {
        int[] unsorted = [12, 2, 24, 51, 8, -5];

        var sorted = HeapSort(unsorted, unsorted.Length);

        for (int i = 0; i < sorted.Length; i++)
        {
            Console.Write($"{sorted[i]} ");
        }
    }
}