using System.Text;

namespace HanonAge
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonGo_Click(object sender, EventArgs e)
		{
			try
			{
				// 読み込み
				Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
				String[] lines = File.ReadAllLines(Environment.GetCommandLineArgs()[1], Encoding.GetEncoding("shift_jis"));

				// 半音上げ
				Boolean canUp = false;
				for (Int32 i = 0; i < lines.Length; i++)
				{
					if (lines[i].StartsWith("[#"))
					{
						// セクション名が数値（[#0000] [#0001]...）なら選択されている音符のセクションなので半音上げてよい
						canUp = Int32.TryParse(lines[i][2..6], out _);
					}

					// "NoteNum=" で始まる行なら音程を指定している行なので、選択されている音符のセクションの場合のみ、半音上げる
					if (lines[i].StartsWith("NoteNum=") && canUp)
					{
						Int32.TryParse(lines[i][8..], out Int32 noteNum);
						noteNum++;
						lines[i] = "NoteNum=" + noteNum.ToString();
					}
				}

				// 保存
				File.WriteAllLines(Environment.GetCommandLineArgs()[1], lines, Encoding.GetEncoding("shift_jis"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("エラー：" + ex.Message);
			}

			Close();
		}
	}
}
