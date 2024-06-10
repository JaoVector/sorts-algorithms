internal class Program
{
    public static void InsertionSort(int[] array, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int key = array[i];
            int j = i;

            while(j > left && array[j - 1] > key)
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = key;
        }
    }

    public static int Partition(int[] array, int left, int right)
    {
        //atribui o pivot como sendo o ultimo elemento do array
        int pivot = array[right];

        //elementos maiores que o pivot serao posicionados a sua direita
        //elementos menores que o pivot serao posicionados a sua esquerda
        int piIndex = left;
        
        //a cada iteração se for encontrado um elemento menor ou igual ao pivot
        //o elemento é colocado antes do pivot e o piIndex é incrementado
        for (int i = left; i < right; i++)
        {
            if(array[i] <= pivot)
            {
                (array[piIndex], array[i]) = (array[i], array[piIndex]);
                piIndex++;
            }
        }

        //swap piIndex com pivot
        (array[piIndex], array[right]) = (array[right], array[piIndex]);

        //retorna o index do elemento do pivot
        return piIndex;
    }

    public static void HybridQuicksort(int[] array, int left, int right)
    {
        while(left < right)
        {
            if(right - left < 10)
            {
                InsertionSort(array, left, right);
                break;
            } else 
            {
                int pivot = Partition(array, left, right);

                //Se o lado esquerdo do pivot for menor que o direito
                // então ordena primeiro o lado esquerdo e mova para a direita
                if(pivot - left < right - pivot)
                {
                    HybridQuicksort(array, left, pivot - 1);
                    left = pivot + 1;
                    
                //Se o lado direito do Pivot for menor que o esquerdo
                // então ordena primeiro o lado direito e mova para o esquerdo
                } else 
                {
                    HybridQuicksort(array, pivot + 1, right);
                    right = pivot - 1;
                }
            }
             
        }
    } 

    private static void Main(string[] args)
    {
        int[] array = [24, 97, 40, 67, 88, 85, 15, 
                    66, 53, 44, 26, 48, 16, 52, 
                   45, 23, 90, 18, 49, 80, 23];

        //int[] unsorted = [10, 2, 8, 1, 4, 6, 3, 5, 7, 9];
        
        HybridQuicksort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}