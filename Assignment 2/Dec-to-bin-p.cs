/*
 * Created by SharpDevelop.
 * User: Abdulrahman AbouOuf
 * Date: 22-Oct-17
 * Time: 8:30 PM
 * convert to binary
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dtop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(v, 2);
            int n= binary.Length-1;
            Console.WriteLine(binary[n-p]);
            Console.ReadKey(true);
        }
    }
}
