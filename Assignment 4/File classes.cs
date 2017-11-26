
using System;

namespace assignment4_file_class
{
	class file{
		public string name="Untitled", type=".txt", opwith="notepad", size="1mg", date="Nov-2017", attributes="Public";
		public void fileassign(string n, string t, string o, string s, string d, string a){
			name = n;
			type = t;
			opwith = o;
			size = s;
			date = d;
			attributes = a;
		}
		
		public void generalprop(){
			Console.WriteLine("Your file name is: {0} and type is: {1} and it is opened with {2} and size is {3} and created in {4} and is {5}", name, type, opwith, size, date, attributes);
		}
	}
	
	class audio : file{
		private string artist="  ", album="  ", genre="  ";		
		private string bitrate="320kbps", length="1min";
		public audio(string ar, string al, string g, string b, string l){
			artist = ar;
			album = al;
			genre = g;
			bitrate = b;
			length = l;
		}
		
		public audio(){
			
		}
		public void detailsa(){
			Console.WriteLine("your song artist is {0} and from {1} album and its genre is {2}", artist, album, genre);
			Console.WriteLine("its duration is {0} and bitrate {1}", length, bitrate);
			if(type==".txt"){
				Console.WriteLine("you didn't assign the type and the program and they will be MP3 and Groove");
				type = "MP3";
				opwith = "Groove";
			}
		}
		
	}
	
	class image : file{
		private int width=1000, hight=1000, resolution=200;
		public image(int w, int h, int r ){
			width = w;
			hight = h;
			resolution = r;
		}
		public image(){
			
		}
		
		public void detailsi(){
			Console.WriteLine("Dimensions {0} x {1} and resolution is {2}", width, hight, resolution);
			if(type==".txt"){
				Console.WriteLine("you didn't assign the type and the program and they will be PNG and image");
				type = "PNG";
				opwith = "Image";
			}
			
		}
	}
	class video : file{
		private int width, hight, resolution, frames;
		public video(int wi, int hi, int res, int f){
			width = wi;
			hight = hi;
			resolution = res;
			frames = f;
		}
		public void detailsv(){
			Console.WriteLine("Dimensions {0} x {1} and resolution is {2} and frame rate {3}", width, hight, resolution, frames);
			if(type==".txt"){
				Console.WriteLine("you didn't assign the type and the program and they will be MP4 and Movies and TV");
				type = "MP4";
				opwith = "Movies and tv";
			}
		}
		
		public video(){
			
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Audio file 1: ");
			audio a1 = new audio();
			a1.generalprop();
			a1.detailsa();
			Console.WriteLine(a1.type);
			Console.WriteLine();
			Console.WriteLine("Audio file 2: ");
			audio a2 = new audio("Vangelis", "Portraits", "New Age", "1000 kbps", "4:48");
			a2.fileassign("Alpha", "FLAC", "Groove", "33 mb", "1997", "Public");
			a2.generalprop();
			a2.detailsa();
			
			Console.ReadKey(true);
		}
	}
}