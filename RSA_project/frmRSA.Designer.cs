namespace RSA
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
			btnTaoKhoa = new Button();
			txtInput = new TextBox();
			txtOutput = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnMaHoa = new Button();
			btnGiaiMa = new Button();
			txtPublicKey = new TextBox();
			txtPrivateKey = new TextBox();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// btnTaoKhoa
			// 
			btnTaoKhoa.Location = new Point(798, 311);
			btnTaoKhoa.Name = "btnTaoKhoa";
			btnTaoKhoa.Size = new Size(212, 46);
			btnTaoKhoa.TabIndex = 0;
			btnTaoKhoa.Text = "Tạo khóa mới";
			btnTaoKhoa.UseVisualStyleBackColor = true;
			btnTaoKhoa.Click += btnTaoKhoa_Click;
			// 
			// txtInput
			// 
			txtInput.Location = new Point(-4, 188);
			txtInput.Multiline = true;
			txtInput.Name = "txtInput";
			txtInput.Size = new Size(697, 783);
			txtInput.TabIndex = 1;
			// 
			// txtOutput
			// 
			txtOutput.Location = new Point(1131, 199);
			txtOutput.Multiline = true;
			txtOutput.Name = "txtOutput";
			txtOutput.Size = new Size(748, 783);
			txtOutput.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(164, 51);
			label1.Name = "label1";
			label1.Size = new Size(142, 32);
			label1.TabIndex = 3;
			label1.Text = "Mã ban đầu";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(1238, 51);
			label2.Name = "label2";
			label2.Size = new Size(129, 32);
			label2.TabIndex = 4;
			label2.Text = "Mã lúc sau";
			// 
			// btnMaHoa
			// 
			btnMaHoa.Location = new Point(798, 544);
			btnMaHoa.Name = "btnMaHoa";
			btnMaHoa.Size = new Size(212, 46);
			btnMaHoa.TabIndex = 0;
			btnMaHoa.Text = "Mã hóa";
			btnMaHoa.UseVisualStyleBackColor = true;
			btnMaHoa.Click += btnMaHoa_Click;
			// 
			// btnGiaiMa
			// 
			btnGiaiMa.Location = new Point(798, 784);
			btnGiaiMa.Name = "btnGiaiMa";
			btnGiaiMa.Size = new Size(212, 46);
			btnGiaiMa.TabIndex = 0;
			btnGiaiMa.Text = "Giải mã";
			btnGiaiMa.UseVisualStyleBackColor = true;
			btnGiaiMa.Click += btnGiaiMa_Click;
			// 
			// txtPublicKey
			// 
			txtPublicKey.BackColor = SystemColors.ActiveCaption;
			txtPublicKey.Location = new Point(402, 104);
			txtPublicKey.Multiline = true;
			txtPublicKey.Name = "txtPublicKey";
			txtPublicKey.ReadOnly = true;
			txtPublicKey.Size = new Size(291, 78);
			txtPublicKey.TabIndex = 5;
			txtPublicKey.TextAlign = HorizontalAlignment.Center;
			// 
			// txtPrivateKey
			// 
			txtPrivateKey.BackColor = SystemColors.ActiveCaption;
			txtPrivateKey.Location = new Point(1559, 119);
			txtPrivateKey.Multiline = true;
			txtPrivateKey.Name = "txtPrivateKey";
			txtPrivateKey.ReadOnly = true;
			txtPrivateKey.Size = new Size(320, 78);
			txtPrivateKey.TabIndex = 6;
			txtPrivateKey.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 122);
			label3.Name = "label3";
			label3.RightToLeft = RightToLeft.No;
			label3.Size = new Size(117, 32);
			label3.TabIndex = 7;
			label3.Text = "PublicKey";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(1107, 122);
			label4.Name = "label4";
			label4.RightToLeft = RightToLeft.No;
			label4.Size = new Size(125, 32);
			label4.TabIndex = 7;
			label4.Text = "PrivateKey";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1880, 981);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtPrivateKey);
			Controls.Add(txtPublicKey);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtInput);
			Controls.Add(txtOutput);
			Controls.Add(btnGiaiMa);
			Controls.Add(btnMaHoa);
			Controls.Add(btnTaoKhoa);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnTaoKhoa;
		private TextBox txtInput;
		private TextBox txtOutput;
		private Label label1;
		private Label label2;
		private Button btnMaHoa;
		private Button btnGiaiMa;
		private TextBox txtPublicKey;
		private TextBox txtPrivateKey;
		private Label label3;
		private Label label4;
	}
}
