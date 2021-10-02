namespace S1Ex8
{
    public class Surroundwith
    {

        public string SurroundWith(string a,string b)
        {
            if (a.Length==4)
            {
                string surrounded = a.Insert(2, b);
                return surrounded;
            }

            return null;
        }
        
        
    }
}