internal class Program
{
    public static void Swap(int[] array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }

    public static void DualPivot(int[] array, int left, int right)
    {
        if(left < right)
        {
            //array para guardar os 2 pivos
            //pivots[0] - pivo da esquerda
            //pivots[1] - pivo da direita
            int[] pivots;
            pivots = Partition(array, left, right);

            DualPivot(array, left, pivots[0] - 1);
            DualPivot(array, pivots[0] + 1, pivots[1] - 1);
            DualPivot(array, pivots[1] + 1, right);

        }
    }

    public static int[] Partition(int[] array, int left, int right)
    {
        if(array[left] > array[right])
        {
            Swap(array, left, right);
        }

        //p é o pivo da esquerda
        //q é o pivo da direita
        int j = left + 1;
        int g = right - 1, k = left + 1;
        int p = array[left], q = array[right];

        while (k <= g)
        {
            //Se os elementos são menores que o pivo
            if(array[k] < p)
            {
                Swap(array, k, j);
                j++;
            } 
            //Se os elementos são maiores ou iguais
            //ao pivo da direita
            else if(array[k] >= q)
            {
                while(array[g] > q && k < g)
                {
                    g--;
                }

                Swap(array, k, g);
                g--;

                if(array[k] < p)
                {
                    Swap(array, k, j);
                    j++;
                }
            }

            k++;
        }

        j--;
        g++;

        //Traz os pivos para suas posições corretas
        Swap(array, left, j);
        Swap(array, right, g);

        //Retorna o Indice dos pivos
        return [j, g];
    }

    private static void Main(string[] args)
    {
        int[] array = [24, 8, 42, 75, 29, 77, 38, 57];

        DualPivot(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(i + " ");
        }
    }
}