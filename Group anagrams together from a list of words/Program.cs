using System.Linq;

internal class Program
{
    public static string[] SearchGroupAnagrams(string[] array, string key)
    {
        string[] vetAux = [];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length == key.Length && array[i] != "null")
            {
                var k = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (key.Contains(array[i][j]))
                    {
                        k++;
                    }
                }

                if (k == array[i].Length)
                {
                    vetAux = [.. vetAux, array[i]];
                    array[i] = "null";
                }
            }
        }

        return vetAux;
    }

    public static string[][] Sort(string[] array)
    {
        bool swapCheck;
        string[][] jagged = [];
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            swapCheck = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].Length > array[j + 1].Length)
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    swapCheck = true;
                }
            }

            if (swapCheck == false)
            {
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != "null")
            {
                var result = SearchGroupAnagrams(array, array[i]);
                jagged = [.. jagged, result];
            }
        }

        return jagged;
    }

    private static void Main(string[] args)
    {
        string[] array = ["CARS", "REPAID", "DUES", "NOSE", "SIGNED", "LANE", "PAIRED", "ARCS", "GRAB", "USED",
                           "ONES", "BRAG", "SUED", "LEAN", "SCAR", "DESIGN"];

        var result = Sort(array);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < result[i].Length; j++)
            {
                Console.Write(result[i][j] + " ");
            }
        }
    }
}