using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace assignment6
{
	
	
	class system{
		List<string> name = new List<string>();
		List<string> gender = new List<string>();
		List<string> email = new List<string>();
		List<string> phone = new List<string>();
		List<string> major = new List<string>();
		
		public system(){
			
			load();
		}
		
		public void load(){
			string[] lines = File.ReadAllLines("data.txt");
			for(int i=0; i<lines.Length; i++){
				string[] line = lines[i].Split(',');
				name.Add(line[0]);
				gender.Add(line[1]);
				email.Add(line[2]);
				phone.Add(line[3]);
				major.Add(line[4]);
			}
		}
		
		
		public void create(){
			Console.Write("Enter your new students name ");
			name.Add(Console.ReadLine());			
			Console.WriteLine();
			Console.Write("Enter your new students gender ");
			gender.Add(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Enter your new students email ");
			email.Add(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Enter your new students phone ");
			phone.Add(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Enter your new students major ");
			major.Add(Console.ReadLine());
			Console.WriteLine();
			
			
		}
		
		public void read(){
			for(int i=0; i<name.Count; i++){
				Console.WriteLine("Student number {0} 's name is {1} and gender {2} and his/her email is {3} and his/her phone is {4} and his/her major is {5}", i+1, name[i], gender[i], email[i], phone[i], major[i]);
			}
			
		}
		public void update(){
			Console.Write("write the name you want to update it's record");
			string nname = Console.ReadLine();
			int f=0;
			for(int i=0; i<name.Count; i++){
				if(name[i] == nname){
					Console.Write("Enter your new students name ");
					name[i] = Console.ReadLine();
					Console.WriteLine();
					Console.Write("Enter your new students gender ");
					gender[i]=(Console.ReadLine());
					Console.WriteLine();
					Console.Write("Enter your new students email ");
					email[i]=(Console.ReadLine());
					Console.WriteLine();
					Console.Write("Enter your new students phone ");
					phone[i]=(Console.ReadLine());
					Console.WriteLine();
					Console.Write("Enter your new students major ");
					major[i]=(Console.ReadLine());
					Console.WriteLine();
					f=1;
				}
			}
			if(f==0){
				Console.WriteLine("the record isn't found we will add it ");
				create();
			}
			uploadtofile();
		}
		
		public void delete(){
			Console.Write("write the name you want to delete from the system ");
			string dname = Console.ReadLine();
			int g=0;
			for(int i=0; i<name.Count; i++){
				if(name[i]==dname){
					name.RemoveAt(i);
					gender.RemoveAt(i);
					email.RemoveAt(i);
					phone.RemoveAt(i);
					major.RemoveAt(i);
					g=1;				
				}
			}
			if(g==0) Console.WriteLine("Record not found");
			
		}
		
		public void uploadtofile(){
			
            StreamWriter sys = new StreamWriter("data.txt", true);
            for(int i=0; i<name.Count; i++){
            	sys.WriteLine(name[i] + ',' + gender[i] + ',' + email[i] +','+ phone[i]+','+major[i]);
            }
            sys.Close();            
		}
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			//StreamWriter sys = new StreamWriter("data.txt", false);
			system s1 = new system();
			l:			Console.WriteLine("if you want to add a student to the system press 1 , read the system press 2, delete one of the system press 3, update press 5");
			int n = Convert.ToInt32(Console.ReadLine());
			if(n==1) s1.create();
			if(n==2) s1.read();
			if(n==3) s1.delete();
			if(n==4) s1.update();
			Console.WriteLine("another process press y");
			char c = Convert.ToChar(Console.ReadLine());
			if(c=='y') goto l;
			s1.uploadtofile();
			Console.ReadKey(true);
		}
	}
}