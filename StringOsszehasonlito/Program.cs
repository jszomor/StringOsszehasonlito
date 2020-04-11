using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOsszehasonlito
{
	class StringCompare : IComparer
	{
		public int Compare(object x, object y)
		{
			return ((string)x).Length - ((string)y).Length;
		}
	}
	class Program
  {
		public static void Bubble(Array oszChar, IComparer comparer)
		{
			for (int i = 0; i < oszChar.Length - 1; ++i)
			{
				for (int j = oszChar.Length - 1; j > i; --j)
				{
					if (comparer.Compare(oszChar.GetValue(j), oszChar.GetValue(j-1)) < 0)
					{
						object tmp = oszChar.GetValue(j);
						oszChar.SetValue(oszChar.GetValue(j - 1), j);
						oszChar.SetValue(tmp, j-1);
					}
				}
			}
		}
		public static void HeapSort()
		{
			//
		}

		static void Main(string[] args)
    {
			string szovegresz;
			string osszszoveg = "";
			while (true)
			{
				Console.WriteLine("Kérem a következő szövegrészt:");

				szovegresz = Console.ReadLine();
				if (szovegresz == "")
				{
					break;
				}
				osszszoveg += szovegresz;
				osszszoveg += " ";
			}
			//Console.WriteLine(osszszoveg);
			char[] elvalaszto = new char[] { ' ', '\t' };
			string[] words = osszszoveg.Split(elvalaszto, StringSplitOptions.RemoveEmptyEntries);

			var compare = new StringCompare();
			//Array.Sort(words, compare);
			Bubble(words, compare);

			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(words[i]);
			}
			Console.ReadKey();
		}
  }
}
