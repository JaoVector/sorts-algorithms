
int[] array = [5, 2, 4, 6, 1, 3];

for (int i = 0; i < array.Length; i++)
{
   var key = array[i];
   int j = i - 1;
   while(j >= 0 && array[j] > key)
   {
      array[j+1] = array[j];
      j = j - 1;
   }

   array[j + 1] = key;
}


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}