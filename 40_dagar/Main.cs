using System;
using System.IO;

class Directory {
	public static void Main(String[] args) { 
		FileStream write, read;
		DateTime k = DateTime.Now;
		int length=0, days=0, lastDate=0, record=0;
		try{
			read = new FileStream("./Dagar.txt", FileMode.OpenOrCreate, FileAccess.Read);
			k = DateTime.Now;

			StreamReader r = new StreamReader(read);
			r.BaseStream.Seek(0, SeekOrigin.Begin);

			length= Int32.Parse(r.ReadLine());
			days= Int32.Parse(r.ReadLine());
			lastDate= Int32.Parse(r.ReadLine());
			record= Int32.Parse(r.ReadLine());
			r.Close();
		}catch(FileNotFoundException e){Console.WriteLine("Caught on read: {0}", e.Message);}
		try{
			if(lastDate!=k.Day)
			{
				write = new FileStream("./Dagar.txt", FileMode.OpenOrCreate, FileAccess.Write);
				StreamWriter w = new StreamWriter(write);
				w.WriteLine(length);
				w.WriteLine(days+1);
				w.WriteLine(k.Day);
				w.WriteLine(record);
			
				w.Flush();
				w.Close();
			}

		}catch(FileNotFoundException e){Console.WriteLine("Caught on write: {0}", e.Message);}
	}
}
