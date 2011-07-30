using System;
using System.IO;

class Directory {
	public static void Main(String[] args) { 
		FileStream write, read;
		StreamWriter w;
		StreamReader r;
		DateTime k = DateTime.Now;
		int length=0, days=0, lastDate=0, record=0;
		try{
			read = new FileStream("/mnt/d/Docs/Anvfiler/Dagar.txt", FileMode.OpenOrCreate, FileAccess.Read);
			k = DateTime.Now;

			r = new StreamReader(read);
			r.BaseStream.Seek(0, SeekOrigin.Begin);

			length= Int32.Parse(r.ReadLine());
			days= Int32.Parse(r.ReadLine());
			lastDate= Int32.Parse(r.ReadLine());
			record= Int32.Parse(r.ReadLine());
			
		}catch(FileNotFoundException e){Console.WriteLine("Caught on read: {0}", e.Message);}

		try{
			if(lastDate==k.Day)
			{
				write = new FileStream("/home/lampan/Dagar.txt", FileMode.OpenOrCreate, FileAccess.Write);
				w = new StreamWriter(write);
				w.WriteLine(length);
				w.WriteLine(days+1);
				w.WriteLine(k.Day);
				w.WriteLine(record);
			}
		
		Console.WriteLine("nisse");

		}catch(FileNotFoundException e){Console.WriteLine("Caught on write: {0}", e.Message);}
		//r.Close();
	}
}