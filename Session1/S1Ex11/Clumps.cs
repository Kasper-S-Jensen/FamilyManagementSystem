namespace ConsoleApp1
{
    public class Clumps
    {

        public int ClumpCalculator(int[] array)
        {
            int arrLength = array.Length;
            int clumps=0;
            for (int i = 0; i < arrLength; i++)
            {
                int flag = 0;
                
                while (i < arrLength - 1 && array[i] == array[i + 1])
                {
                    flag = 1;
                    i++;
                }
 
                if (flag == 1)
                    clumps++;
            }

            return clumps;
        }
    }
}