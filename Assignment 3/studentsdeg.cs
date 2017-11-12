/*
 * Created by SharpDevelop.
 * User: Abdulrahman AbouOuf
 * Date: 10-Nov-17
 * Time: 10:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace assignment3
{
    class Program
    {
        public static int search(params string[] list){
            Console.WriteLine("Please enter a student's name");
            string s = Console.ReadLine();
            int z=0 , f=0;
            for(int i=0; i<list.Length; i++){
                if(s==list[i]){
                    z=i;
                    f=1;
                    break;
                }
            }
            if(f==1) return z;
            else{
                Console.WriteLine("Not found");
                return list.Length+1;
            }
            
            
        }
        public static int top(params int[] list){
            int mx=0;
            int z=0;
            for(int i=0; i<list.Length; i++){
                if(list[i]>mx){
                    mx = list[i];
                    z=i;
                }
            }
            return z;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");
            int n=Convert.ToInt32(Console.ReadLine());
            string[] name = new string[n];
            int[] deg = new int[n];
            for(int i=0; i<n; i++){
                Console.WriteLine("Enter student {0} name", i+1);
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter hs/her degree");
                deg[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Choose an option from the following menu");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Search for a student degree");
            Console.WriteLine("[2] Get top student name and degree");
            Console.WriteLine("[3] Change a student's name");
            Console.Write("Please enter your choice  ");
            int m = Convert.ToInt32(Console.ReadLine());
            if(m==1){
                int x=search(name);
                if(x<n) Console.WriteLine("Student {0} score is : {1} ", name[x], deg[x]);
            }
            if(m==2){
                int x=top(deg);
                Console.WriteLine("Top student is {0} and his/her degree is : {1}", name[x], deg[x]);
            }
            if(m==3){
                Console.WriteLine("Type the name of student to be changed (old name)");
                string c = Console.ReadLine();
                int v = Array.IndexOf(name, c);
                Console.WriteLine("Enter new name");
                string a = Console.ReadLine();
                name.SetValue(a, v);
                Console.WriteLine("Name succefully changed from {0} to {1} ", c , a);
                if(v<n-1) Console.WriteLine("{0}  {1}  ...." , name[v], name[v+1]);
            }
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
