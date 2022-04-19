namespace Algorithms_DataStruct_Lib
{
    public static class ThreeSum
    {
        public static int Count(int[] a)
        {
            int length = a.Length;
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;

        }
    }
}