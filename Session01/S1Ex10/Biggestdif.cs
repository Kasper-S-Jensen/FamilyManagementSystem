using System.Linq;

namespace S1Ex10
{
    public class Biggestdif
    {


        public int LargestDiff(int[] array)
        {
            int biggest=array.Max();
            int smallest = array.Min();
            return biggest-smallest;
        }
    }
}