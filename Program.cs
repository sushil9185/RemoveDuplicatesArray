namespace RemoveDuplicatesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4 };
            Console.WriteLine("Orignal Array");
            PrintArr(myarray);
            Console.WriteLine("After removing duplicates");
            //FindDuplicate(myarray);
            //OptimFindDuplicate(myarray);
            
            Console.WriteLine("Unique Elements: " + OptimFindDuplicate(myarray));
            //PrintArr(myarray);
        }

        static void FindDuplicate(int[] a) 
        {
            //Dictionary<int,int> dict = new Dictionary<int,int>();
            HashSet<int> hSet = new HashSet<int>();

            for(int i = 0; i < a.Length; i++)
            {
                hSet.Add(a[i]);
            }

            int j = 0;
            foreach(int hNum in hSet)
            {
                a[j] = hNum;
                j++;
            }

            PrintArr(a);

        }

        static int OptimFindDuplicate(int[] a)
        {
            int j = 0;
            for(int i = 1; i < a.Length; i++)
            {
                if (a[j] != a[i])
                {
                    j++;
                    a[j] = a[i];
                }
            }

            return j + 1;

        }

        static void PrintArr(int[] a)
        {
            for(int i = 0; i < a.Length ; i++) 
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}