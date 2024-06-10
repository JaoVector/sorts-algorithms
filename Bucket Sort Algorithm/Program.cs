internal class Program
{

    public static int[] BucketSort(int[] array)
    {
        if(array == null || array.Length <= 1)
        {
            return array;
        }

        int maxValue = array[0];
        int minValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxValue)
            {
                maxValue = array[i];
            }

            if(array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

        for (int i = 0; i < array.Length; i++)
        {
            if (bucket[array[i] - minValue] == null)
            {
                bucket[array[i] - minValue] = new LinkedList<int>();
            }

            bucket[array[i] - minValue].AddLast(array[i]);
        }

        var index = 0;

        for (int i = 0; i < bucket.Length; i++)
        {
            if(bucket[i] != null)
            {
                LinkedListNode<int> node = bucket[i].First;

                while (node != null)
                {
                    array[index] = node.Value;
                    node = node.Next;
                    index++;
                }
            }
        }

        return array;
    }

    private static void Main(string[] args)
    {
        int[] array = [73, 57, 49, 99, 133, 20, 1];
        BucketSort(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
 /*

public static void InsertionSort(List<float> bucket)
    {
        for (int i = 1; i < bucket.Count; i++)
        {
            var key = bucket[i];
            int j = i - 1;

            while(j >= 0 && bucket[j] > key)
            {
                bucket[j + 1] = bucket[j];
                j--;
            }

            bucket[j + 1] = key;
        }
    }

    public static void BucketSort(float[] array)
    {
        int n = array.Length;
        var buckets = new List<float>[n];

        //Criando Buckets vazios
        for (int i = 0; i < n; i++)
        {
            buckets[i] = [];
        }

        //Colocando os elementos do Array em diferentes Buckets
        for (int i = 0; i < n; i++)
        {
            int bktIndex = (int)(n * array[i]);
            buckets[bktIndex].Add(array[i]);
        }

        //Oredena os Bucktes individualmente
        for (int i = 0; i < n; i++)
        {
            InsertionSort(buckets[i]);
        }

        //Concatena todos os Buckets ordenados dentro do Array
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < buckets[i].Count; j++)
            {
                array[index++] = buckets[i][j];
            }
        }
    }

 */