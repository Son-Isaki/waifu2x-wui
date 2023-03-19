namespace Waifu2xWui
{
	public class OutputFile
	{
		public bool IsActive { get; set; } = true;
		public int Width { get; set; } = 720;
		public int NoiseReduction { get; set; } = 1;
		public string Extension { get; set; } = string.Empty;
		public string Suffix { get; set; } = string.Empty;

		public string GetOutputFilename(string sourceFilename)
		{
			var segs = sourceFilename.Split('.');
			var outputFilename = string.Join(".", segs.SkipLast(1));

			if (Suffix.Length > 0)
			{
				outputFilename += "@" + Suffix;
			}

			outputFilename += "." + Extension.Trim('.');

			return outputFilename;
		}

		public bool CompareWithSourceFilename(string sourceFilename)
		{
			return (GetOutputFilename(sourceFilename) == sourceFilename);
		}
	}
}