using System;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: This example was taken from dotnetperls.com
            // unchecked = no exception thrown during second loop
            int counter2 = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                counter2++;
            }
            Console.WriteLine("Counter2 Value: {0}", counter2);
            for (int i = 0; i < int.MaxValue; i++)
            {
                counter2++;
            }
            Console.WriteLine("Counter2 Value: {0}", counter2);

            // checked = exception thrown during second loop
            int counter = 0;
            checked
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    counter++;
                }
                Console.WriteLine("Counter Value: {0}", counter);
                for (int i = 0; i < int.MaxValue; i++)
                {
                    counter++;
                }
            }


        }
    }
}
