namespace Algorithm
{
	public class Feistel
	{
		public static string Encrypting(string text, string key, int blocksNum = 2)
		{
			while (text.Length % blocksNum != 0)
			{
				text += " "; //добавляем пустой символ
			} //увеличиваем текст до кратного кол-ву блоков

			int blockLength = text.Length / blocksNum;
			string[] blocks = new string[blocksNum];

			for (int i = 0; i < text.Length; ++i)
			{
				if (i / blockLength < 1)
				{
					blocks[blocksNum - 1] += text[i];
				}
				else
				{
					blocks[i / blockLength - 1] += text[i];
				}
			} //создаём блоки для удобной работы, меняем их местами
			string keyBlock = Main.Program.TextXOR(blocks[blocksNum - 1], key);
			string result = "";

			for (int i = 0; i < blocksNum - 1; ++i)
			{
				blocks[i] = Main.Program.TextXOR(blocks[i], keyBlock);
				result += blocks[i];
			} //шифруем остальние блоки, добавляем к ответу
			result += blocks[blocksNum - 1];

			return result;
		}
		
		public static string Decrypting(string text, string key, int blocksNum = 2)
		{
			while (text.Length % blocksNum != 0)
			{
				text += " "; //добавляем пустой символ
			} //увеличиваем текст до кратного кол-ву блоков

			int blockLength = text.Length / blocksNum;
			string[] blocks = new string[blocksNum];

			for (int i = 0; i < text.Length; ++i)
			{
				if (i / blockLength >= blocksNum - 1)
				{
					blocks[0] += text[i];
				}
				else
				{
					blocks[i / blockLength + 1] += text[i];
				}
			} //создаём блоки для удобной работы, меняем их местами
			string keyBlock = Main.Program.TextXOR(blocks[0], key);
			string result = "";

			result += blocks[0];
			for (int i = 1; i < blocksNum; ++i)
			{
				blocks[i] = Main.Program.TextXOR(blocks[i], keyBlock);
				result += blocks[i];
			} //шифруем остальние блоки, добавляем к ответу

			return result;
		}
	}
}