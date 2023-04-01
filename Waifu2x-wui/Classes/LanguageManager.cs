using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waifu2xWeb;

namespace Waifu2xWui
{
	public class Language
	{
		protected CultureInfo culture;
		protected string name;
		protected string iso;

		public Language(CultureInfo culture)
		{
			this.culture = culture;
			name = culture.TextInfo.ToTitleCase(culture.NativeName);
			iso = culture.TwoLetterISOLanguageName.ToUpper();
		}

		public CultureInfo Culture => culture;
		public string Name => name;
		public string Iso => iso;
	}

	public class LanguageManager
	{
		protected ComponentResourceManager manager;
		protected List<Language> availableLanguages = new List<Language>();

		public void LoadAvailableLanguages(Type componentType)
		{
			availableLanguages.Clear();

			manager = new ComponentResourceManager(componentType);
			foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
			{
				try
				{
					var res = manager.GetResourceSet(culture, true, false);
					if (res != null && culture.TwoLetterISOLanguageName != "iv")
					{
						availableLanguages.Add(new Language(culture));
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		public List<Language> GetAvailableLanguages() => availableLanguages;

		public void SwitchToLanguage(Control control, Language language)
		{
			if (language != null)
			{
				Thread.CurrentThread.CurrentCulture = language.Culture;
				Thread.CurrentThread.CurrentUICulture = language.Culture;
				ApplyLanguageToControls(control, manager, language.Culture);
			}
			else
			{
				Logger.Log($"cheh", LogType.Error);
			}
		}

		protected void ApplyLanguageToControls(
			Control control,
			ComponentResourceManager cmp,
			CultureInfo cultureInfo)
		{
			cmp.ApplyResources(control, control.Name, cultureInfo);

			foreach (Control child in control.Controls)
			{
				ApplyLanguageToControls(child, cmp, cultureInfo);
			}
		}
	}
}