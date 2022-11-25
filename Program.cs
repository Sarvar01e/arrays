namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");

            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int [size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter element:"+i);
                int element = int.Parse(Console.ReadLine());
                array1[i] = element;
                
            }

            for (int k = 0; k < array1.Length; k++)
            {
                Console.Write("element: "+k);
                Console.WriteLine("  = "+array1[k]);
            }

            Console.ReadLine();
        }
    }
}