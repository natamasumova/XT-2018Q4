namespace Epam.Task4._4
{
    public static class ArrayExtension
    {
        public static int CountElements(this int[] array)
        {
            int sum = 0;
            int i = 0;
            while (i < array.Length)
            {
                sum += array[i];
                i++;
            }
            return sum;
        }

        public static double CountElements(this double[] array)
        {
            double sum = 0;
            int i = 0;
            while (i < array.Length)
            {
                sum += array[i];
                i++;
            }
            return sum;
        }
    }
}
