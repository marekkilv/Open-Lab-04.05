using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
                string new_string = "";
            char[] characters = orig.ToCharArray();
            foreach (var item in characters)
            {
                for (int i = 0; i < n; i++)
                {
                    new_string = new_string + item;
                }
            }
            return new_string;
        }
    }
}
