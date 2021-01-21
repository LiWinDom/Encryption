using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Encryption;

namespace Main
{
	public class Program
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