namespace İnsertArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 23, 654, 4, 234, 87, 9 };
            Console.WriteLine("Arrayin Ilk uzunlugu: "+ Array.Length);
            İnsertArray(ref Array,45,23,35,76,38,95);
            Console.WriteLine("\n"+"Arrayin Son uzunlugu: " + Array.Length);
            
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("\n"+$"Arrayin {i+1} elementi: "+Array[i]);
            }
            

        }
        static void İnsertArray(ref int[] array, params int[] arr1)
        {
            int j = 0;
            int[] arr= new int[arr1.Length+array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];               
            }
            for (int i = array.Length; i < arr.Length; i++)
            {               
                    arr[i] = arr1[j];
                    j++;                
            }

            array = arr;
        }


        
    }
}
