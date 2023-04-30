namespace Algorithms
{
	internal class CharCountClass
	{
		//Multiple character Count
		static internal IList<IList<int>> CharCount(string s)
		{
			IList<IList<int>> list = new List<IList<int>>();
			int l = s.Length <= 1000 ? s.Length : 1000;

			for (int i = 0; i < l - 2; i++)
			{
				int j = 0;
				while (s[i + j + 1] == s[i] && j < l && s == s.ToLower())
				{
					j++;
				}
				if (j >= 2)
					list.Add(new List<int> { i, i + j });

				i += j;
			}

			Console.WriteLine(s + "\n");
			foreach (var item in list)
			{
				Console.WriteLine(item[0] + ", " + item[1]);
			}
			Console.ReadLine();

			return list;
		}
	}
}