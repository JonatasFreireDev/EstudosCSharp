using System;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            int output = 0;

            Console.WriteLine("Open Database Connection");
            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                //throw;
                throw new ArgumentException("You passed in bad data", ex);
            }
            finally
            {
                Console.WriteLine("Close Database Connection");
            }

            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;

            //try
            //{
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            return output;
        }
    }
}