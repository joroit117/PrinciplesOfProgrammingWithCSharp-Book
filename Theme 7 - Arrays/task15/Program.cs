using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            string word = Console.ReadLine();
            for(int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if((int)c > (int)'A' && (int)c < (int)'Z')
                {
                    index = (int)c - (int)'A';
                }
                else if ((int)c > (int)'a' && (int)c < (int)'z')
                {
                    index = (int)c - (int)'a';
                }
                Console.Write(index + " ");
            }
        }
    }
}
