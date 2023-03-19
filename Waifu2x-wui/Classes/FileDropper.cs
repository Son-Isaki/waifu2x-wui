namespace Waifu2xWui
{
	public class FileDropper
	{
		Form form;

		public Action<string> OnFileDropped;

		public FileDropper(Form form)
		{
			this.form = form;
		}

		public void Initialize()
		{
			// allow drop
			form.AllowDrop = true;

			// on drag enter
			form.DragEnter += new DragEventHandler((object? sender, DragEventArgs e) =>
			{
				if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Move;
			});

			// on file dropped
			form.DragDrop += new DragEventHandler((object? sender, DragEventArgs e) =>
			{
				string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop));
				foreach (string filepath in files)
				{
					OnFileDropped?.Invoke(filepath);
				}
			});
		}
	}
}