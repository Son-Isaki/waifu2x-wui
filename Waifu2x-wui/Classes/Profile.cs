using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waifu2xWui;

namespace Waifu2xWeb
{
	public enum Device
	{
		GPU,
		CPU,
	}

	public class Profile
	{
		public string SourceFilename { get; set; } = string.Empty;
		public List<OutputFile> OutputFiles { get; set; } = new List<OutputFile>();
		public string Model { get; set; } = string.Empty;
		public Device Device { get; set; }
		public int NoiseReduction { get; set; }

		public void SetDefaults()
		{
			OutputFiles.Clear();
			OutputFiles.Add(new OutputFile()
			{
				IsActive = true,
				Width = 720,
				NoiseReduction = 2,
				Extension = "webp",
				Suffix = "1x"
			});
			OutputFiles.Add(new OutputFile()
			{
				IsActive = true,
				Width = 1920,
				NoiseReduction = 2,
				Extension = "webp",
				Suffix = "2x"
			});
			Model = "anime_style_art_rgb";
			Device = Device.GPU;
			NoiseReduction = 1;
		}
	}
}
