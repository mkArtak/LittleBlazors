using System;
using System.Text;

namespace LittleBlazors.TestHost.Utilities
{
    public static class RandomUtilities
    {
        private static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public static int[] GetRandomNumberArray(int length, int maxValue)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = rnd.Next(maxValue);
            }

            return result;
        }

        public static string GetRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                builder.Append(GetRandomChar());
            }

            return builder.ToString();
        }

        private static char GetRandomChar()
        {
            return (char)rnd.Next('a', 'z');
        }
    }
}
