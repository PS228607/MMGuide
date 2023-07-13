namespace nameSpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str1 = "anagram";
            string str2 = "margana";

            char[] ch1 = str1.ToLower().ToCharArray(); //Convert string to array
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1); //Sort array on alphabetically order
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2) //checks if the arrays contain the same letters
            {
                Console.WriteLine("Both the strings are anagram");
            }
            else 
            {
                Console.WriteLine("Both the string are not Anagrams");
            }
        }
    }
}
