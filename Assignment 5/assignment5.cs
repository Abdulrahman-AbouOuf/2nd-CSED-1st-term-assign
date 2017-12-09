using System;

namespace assignment5
{
	class Device{
		public string type;
		public int nf=0, nd=0;
		public string[] ddir = new string[100];
		public string[] dfile = new string[100];
		public string[] sysview = new string[100];
		
		public Device(string t){
			this.type = t;
		}
		
		public void addfile(string namefile, string typefile){
			dfile[nf]=namefile;
			nf++;
			
			DateTime creation = DateTime.Now;			
			Console.WriteLine("save to!");
			string dir = Console.ReadLine();
			
			int f=0;
			for(int i=0; i<100; i++){
				if(ddir[i]==dir){
					sysview[i] = sysview[i]+ " directory " + ddir[i] + " has " + namefile+"."+typefile + " created "+ creation ;
					f=1;
					break;
				}
				
			}
			if(f==0){
					ddir[nd] = dir;
					sysview[nd]= dir+ " has " + namefile+"."+typefile + " created " + creation;
					nd++;
				}
		}
		
		public void modify(){
			Console.WriteLine("write the file you want to modify");
			string name = Console.ReadLine();
			int x=0;
			for(int i=0; i<nf; i++){
				if(dfile[i]== name){
					DateTime modified = DateTime.Now;
					dfile[i]=dfile[i]+ " modified " + modified;
					x=1;
					break;
				}
			}
			if(x==0) Console.WriteLine("file doesn't exist");
		}
		
		
		public void viewsys(){
			Console.WriteLine("your device type is {0} and it has {1} files and it has {2} directories", type, nf, nd);
			for(int i=0; i<nd; i++) Console.WriteLine(sysview[i]);
			Console.WriteLine("the file in the system and if any were modified");
			for(int j=0; j<nf; j++){
				Console.WriteLine(dfile[j]);
			}
		}
		
		
		
		
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Device h1 = new Device("harddisk");
			Console.WriteLine("write number of file you want to save in h1");		
			int n = Convert.ToInt32( Console.ReadLine());
			for(int i=0; i<n; i++){
				Console.WriteLine("write the number {0} file name", i+1);
				string nm = Console.ReadLine();
				Console.WriteLine(" write the file {0} type", i+1);
				string t = Console.ReadLine();
				h1.addfile(nm,t);
			}
			Console.WriteLine("do you want to modify a file y/n");
			Char c = Convert.ToChar(Console.ReadLine());
			if(c=='y'){
				h1.modify();				
			}
			
			h1.viewsys();
			Console.WriteLine("=================================");
			Device CD1 = new Device("CD");
			Console.WriteLine("write number of file you want to save in CD1");		
			n = Convert.ToInt32( Console.ReadLine());
			for(int i=0; i<n; i++){
				Console.WriteLine("write the number {0} file name", i+1);
				string nm = Console.ReadLine();
				Console.WriteLine(" write the file {0} type", i+1);
				string t = Console.ReadLine();
				CD1.addfile(nm,t);
			}
			CD1.viewsys();
			Console.ReadKey(true);
		}
	}
}