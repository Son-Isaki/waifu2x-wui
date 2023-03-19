using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Waifu2xWui.MainForm;
using System.Windows.Forms;

namespace Waifu2xWeb
{
	public enum LogType
	{
		Info,
		Error,
		Warning,
		Success,
	}

	public static class Logger
	{
		public static RichTextBox Console { get; private set; }

		public static void SetConsole(RichTextBox console)
		{
			Console = console;
			Console.Clear();
		}

		public static void Log(object message, LogType type = LogType.Info)
		{
			if (Console == null)
				return;

			if (message == null)
				return;

			try
			{
				var length = Console.TextLength;
				var textToAdd = $"[{type}] {message}{Environment.NewLine}";

				Console.AppendText(textToAdd);

				Console.SelectionStart = length;
				Console.SelectionLength = textToAdd.Length;

				switch (type)
				{
					case LogType.Info: Console.SelectionColor = ColorTranslator.FromHtml("#2f87ea"); break;
					case LogType.Success: Console.SelectionColor = ColorTranslator.FromHtml("#87cb82"); break;
					case LogType.Warning: Console.SelectionColor = ColorTranslator.FromHtml("#ffc021"); break;
					case LogType.Error: Console.SelectionColor = ColorTranslator.FromHtml("#ec5872"); break;
				}

				Console.ScrollToCaret();
			}
			catch (Exception ex)
			{
				//Log(ex.Message, LogType.Error);
			}
		}
	}
}
