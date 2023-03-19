using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using Waifu2xWeb;

namespace Waifu2xWui
{
	public class ProfileManager
	{
		public const string FILENAME = "profile.json";

		public Profile? Load(string filename)
		{
			Profile? profile = null;

			if (File.Exists(filename))
			{
				var fullpath = Path.Combine(AppContext.BaseDirectory, filename);
				var contents = File.ReadAllText(fullpath);
				profile = JsonConvert.DeserializeObject<Profile>(contents);
			}

			/*if (profile == null)
			{
				profile = new Profile();
				profile.SetDefaults();
			}*/

			return profile;
		}

		public void Save(Profile profile, string filename)
		{
			var contents = JsonConvert.SerializeObject(profile);
			var fullpath = Path.Combine(AppContext.BaseDirectory, filename);
			File.WriteAllText(fullpath, contents);
		}
	}
}
