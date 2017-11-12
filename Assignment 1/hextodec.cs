/*
 * Created by SharpDevelop.
 * User: Abdulrahman AbouOuf
 * Date: 29-Oct-17
 * Time: 8:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dectohex
{
    class Program
    {
        public static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine(dec);
            Console.Read();

        }
    }
}
