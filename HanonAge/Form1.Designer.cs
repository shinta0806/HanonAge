namespace HanonAge
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			ButtonGo = new Button();
			ButtonCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 19);
			label1.Name = "label1";
			label1.Size = new Size(157, 15);
			label1.TabIndex = 0;
			label1.Text = "選択された音符を半音上げます";
			// 
			// ButtonGo
			// 
			ButtonGo.Location = new Point(23, 49);
			ButtonGo.Name = "ButtonGo";
			ButtonGo.Size = new Size(75, 23);
			ButtonGo.TabIndex = 1;
			ButtonGo.Text = "実行";
			ButtonGo.UseVisualStyleBackColor = true;
			// 
			// ButtonCancel
			// 
			ButtonCancel.Location = new Point(114, 49);
			ButtonCancel.Name = "ButtonCancel";
			ButtonCancel.Size = new Size(75, 23);
			ButtonCancel.TabIndex = 2;
			ButtonCancel.Text = "キャンセル";
			ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AcceptButton = ButtonGo;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = ButtonCancel;
			ClientSize = new Size(210, 91);
			Controls.Add(ButtonCancel);
			Controls.Add(ButtonGo);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "半音上げ";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button ButtonGo;
		private Button ButtonCancel;
	}
}
