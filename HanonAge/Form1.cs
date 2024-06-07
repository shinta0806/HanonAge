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
				// �ǂݍ���
				Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
				String[] lines = File.ReadAllLines(Environment.GetCommandLineArgs()[1], Encoding.GetEncoding("shift_jis"));

				// �����グ
				Boolean canUp = false;
				for (Int32 i = 0; i < lines.Length; i++)
				{
					if (lines[i].StartsWith("[#"))
					{
						// �Z�N�V�����������l�i[#0000] [#0001]...�j�Ȃ�I������Ă��鉹���̃Z�N�V�����Ȃ̂Ŕ����グ�Ă悢
						canUp = Int32.TryParse(lines[i][2..6], out _);
					}

					// "NoteNum=" �Ŏn�܂�s�Ȃ特�����w�肵�Ă���s�Ȃ̂ŁA�I������Ă��鉹���̃Z�N�V�����̏ꍇ�̂݁A�����グ��
					if (lines[i].StartsWith("NoteNum=") && canUp)
					{
						Int32.TryParse(lines[i][8..], out Int32 noteNum);
						noteNum++;
						lines[i] = "NoteNum=" + noteNum.ToString();
					}
				}

				// �ۑ�
				File.WriteAllLines(Environment.GetCommandLineArgs()[1], lines, Encoding.GetEncoding("shift_jis"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("�G���[�F" + ex.Message);
			}

			Close();
		}
	}
}
