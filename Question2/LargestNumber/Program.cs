namespace LargestNumber
{
    class LargeNum
    {
        // Find largest number in an array
        static int LargeNumber(int[] arr)
        {
            // Initialize 1st number as large number
            int large = arr[0];

            // Compare remaining elements and update largest value if found 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }
            }

            return large;
        }

        static void Main(string[] args)
        {
            try
            {

                // Take size of array from user
                Console.Write("Enter number of elements: ");
                int n = int.Parse(Console.ReadLine());

                // Array contains at least one element
                if (n <= 0)
                {
                    Console.WriteLine("Array size must be greater than zero...");
                    return;
                }

                // Initalize array with given size
                int[] arr = new int[n];

                // Enter element in array
                Console.WriteLine("Enter the elements: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                // Call the method & get large number from array
                int num = LargeNumber(arr);

                // Print largest number from array
                Console.WriteLine($"{num} is the largest number in an array.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input...");
            }
        }
    }
}