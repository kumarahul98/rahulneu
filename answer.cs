using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter teh size of array :");
		int s=Convert.ToInt32(Console.ReadLine());
		int[] n=new int[s];
		int[] nn=new int[s];
		Console.WriteLine("Enter teh array vlaues:\n");
		for (int i=0;i<s;i++)
		{
			n[i]=Convert.ToInt32(Console.ReadLine());
			if(i%2==0)
			{
				nn[i]=n[i]+1;
			}
			else
			{
				nn[i]=n[i]-1;
			}
		}
		foreach(int i in nn)
		{
			Console.WriteLine(i);
		}
	}
}
