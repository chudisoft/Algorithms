
namespace Algorithms
{
    internal class NumFlipClass
    {
		static internal int[] NumFlip(int[] newNums)
		{
			//Number Flip
			//int[] newNums = { 1, 2, 3, 4, 5 };
			for (int i = 0; i < 2; i++)
			{
				int[] newNums1 = newNums.ToList().ToArray();
				for (int j = 0; j < newNums.Length - 1; j++)
				{
					newNums1[j + 1] = newNums[j];
				}
				newNums1[0] = newNums[newNums1.Length - 1];
				newNums= newNums1.ToList().ToArray();
				foreach (var item in newNums)
				{
					Console.Write(item + ",");
				}
				Console.WriteLine("\n");
			}
			Console.ReadLine();
			return newNums;
		}
    }
}