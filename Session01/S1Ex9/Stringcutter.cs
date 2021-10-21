namespace S1Ex9
{
    public class Stringcutter
    {
        public string CutTheString(string word, int length)
        {
            string result1 = word.Substring(0, length);
            string result2 = word.Substring(word.Length - length, length);
            string randomword = result1 + result2;
           return randomword;
        }
    }
}