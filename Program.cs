using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_answer_of_The_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] A = new int[n];
            for (int x = 0; x <n; x++)
            {
                A[x] =int.Parse(Console.ReadLine());//adad ha moratab dade shavad
            }
            int R = -1, x1 = 0, x2 = n- 1;
            int p = int.Parse(Console.ReadLine());
            while (x1 <= x2)
            {
                int mid = (x1 + x2) / 2;
                if (p == A[mid])
                {
                    R = mid;
                    break;
                }
                if (p > A[mid])
                    x1 = mid + 1;
                if (p < A[mid])
                    x2 = mid - 1;


            }
            Console.WriteLine(R);
            Console.ReadKey();


        }
    }
}
