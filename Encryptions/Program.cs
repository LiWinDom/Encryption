using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Encryptions;

namespace Main
{
	public static class Program
	{
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new mainWindow());
		}

		public static string TextXOR(string text, string key)
		{
			string encrypted = "";
			int keyPointer = 0;
			for (int i = 0; i < text.Length; ++i, ++keyPointer)
			{
				while (keyPointer >= key.Length)
				{
					keyPointer -= key.Length;
				}
				int textValue = text[i];
				int keyValue = key[keyPointer];
				char encryptedSymbol = Convert.ToChar(textValue ^ keyValue);
				encrypted += encryptedSymbol;
			}
			return encrypted;
		}
	}
}

namespace Functions
{
    public class Encrypting
    {
        public static string Feistel(string text, string key, int blocksNum = 2)
		{
			if (blocksNum > text.Length)
            {
				blocksNum = text.Length;
            }
			while (text.Length % blocksNum != 0)
			{
				text += " "; //добавляем пустой символ
			} //увеличиваем текст до кратного кол-ву блоков

			int blockLength = text.Length / blocksNum;
			string[] blocks = new string[blocksNum];
			//blocks.resize(blocksNum);
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
	}
}
