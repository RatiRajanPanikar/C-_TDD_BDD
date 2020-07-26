using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class LogicalLoops
    {
        //Test to display palindrome in a method
        public static bool IsPalidrome(string words)
        {
            int min = 0;
            int max = words.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char first = words[min];
                char last = words[max];
                if (words.ToLower()[first] != words.ToLower()[last])
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public static void main(string[] args)
        {
            string[] Words = { "radar", "level", "refer", "palin", "drome" };

            foreach (string w in Words)
            {
                Console.WriteLine("{0} : {1}", w, IsPalidrome(w));
            }

        }
        
            

}
}
