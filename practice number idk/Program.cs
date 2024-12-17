namespace practice_number_idk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "ab";
            string word2 = "pqrs";
            string res = CombinedString(word1, word2);
            Console.WriteLine(res);
        }



        public static string CombinedString(string word1, string word2) 
        {
           int i = 0;
           int j = 0;
        var merged = new System.Text.StringBuilder();
            while (i < word1.Length && j < word2.Length) 
            {
                merged.Append(word1[i++]);
                merged.Append(word2[j++]);
            }
            
            while(j < word2.Length) 
            {
                merged.Append(word2[j++]);
            }
            return merged.ToString();
            
            
        }
    }



}
