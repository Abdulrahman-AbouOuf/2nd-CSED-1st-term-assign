/*
 * Created by SharpDevelop.
 * User: Abdulrahman AbouOuf
 * Date: 22-Oct-17
 * Time: 8:00 PM
 * convert number to string
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace convert999
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] o = new string[] {"one","two","three","four","five","six","seven","eight","nine"};
            string[] x = new string[] {"ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","ninteen"};
            string[] t = new string[] {"twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninty","nine"};
            int k1=0;
            int k2=0;
            int k3=0;
            
            int n=Convert.ToInt32(Console.ReadLine());
            if((n>=1)&&(n<=9)) Console.WriteLine(o[n-1]);
            if((n>=10)&&(n<=19)) Console.WriteLine(x[n-10]);
            if((n>19)&&(n<=99)){
                k2=n/10;
                Console.Write(t[k2-2]);
                if(n%10!=0){
                    k1=n%10;
                    Console.WriteLine(" {0}", o[k1-1]);
                }
               }
            if((n>99)&&(n<=999)){
                k3=n/100;
                Console.Write("{0} hundred", o[k3-1]);
                k2=n%100;
                if((k2%10==0)&&(k2/10!=0)) Console.Write(" {0}", t[k2/10-2]);
                else if((k2%10!=0)&&(k2/10!=0)){
                    Console.Write(" {0}", t[k2/10-2]);
                    Console.WriteLine(" {0}", o[(k2%10)-1]);
                }
                else if((k2%10!=0)&&(k2/10==0)) Console.WriteLine(" {0}", o[(k2%10)-1]);
            }
            Console.Read();
                                             
            
        }
    }
}
