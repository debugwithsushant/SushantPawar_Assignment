namespace PalindromeChecker
{
    class Palindrome
    {
        // Check given string is palindrome or not
        static bool IsPalindrome(string str)
        {
            // Start pointer & End pointer
            int left = 0;
            int right = str.Length - 1;

            // Loop till both pointers meet
            while (left < right)
            {

                // Check characters match or not
                if (str[left] != str[right])
                {
                    return false;
                }

                // Move pointers towards center
                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            // Take input from user
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            // Check input is empty or not, if empty then stop
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Please enter string...");
                return;
            }

            // Remove space & convert to lowercase for comparision
            string newStr = str.Replace(" ", "").ToLower();

            // Check palindrome & display result
            if (IsPalindrome(newStr))
            {
                Console.WriteLine($"{str} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{str} is NOT Palindrome.");
            }
        }
    }
}