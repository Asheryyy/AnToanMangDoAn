namespace RSA
{
	partial class frmRSA
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
            btnTaoKhoa.Location = new Point(491, 194);
            btnTaoKhoa.Margin = new Padding(2, 2, 2, 2);
            btnTaoKhoa.Name = "btnTaoKhoa";
            btnTaoKhoa.Size = new Size(130, 29);
            btnTaoKhoa.TabIndex = 0;
            btnTaoKhoa.Text = "Tạo khóa mới";
            btnTaoKhoa.UseVisualStyleBackColor = true;
            btnTaoKhoa.Click += btnTaoKhoa_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(-2, 118);
            txtInput.Margin = new Padding(2, 2, 2, 2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(430, 491);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(696, 124);
            txtOutput.Margin = new Padding(2, 2, 2, 2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(462, 491);
            txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã ban đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(762, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Mã lúc sau";
            // 
            // btnMaHoa
            // 
            btnMaHoa.Location = new Point(491, 340);
            btnMaHoa.Margin = new Padding(2, 2, 2, 2);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(130, 29);
            btnMaHoa.TabIndex = 0;
            btnMaHoa.Text = "Mã hóa";
            btnMaHoa.UseVisualStyleBackColor = true;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // btnGiaiMa
            // 
            btnGiaiMa.Location = new Point(491, 490);
            btnGiaiMa.Margin = new Padding(2, 2, 2, 2);
            btnGiaiMa.Name = "btnGiaiMa";
            btnGiaiMa.Size = new Size(130, 29);
            btnGiaiMa.TabIndex = 0;
            btnGiaiMa.Text = "Giải mã";
            btnGiaiMa.UseVisualStyleBackColor = true;
            btnGiaiMa.Click += btnGiaiMa_Click;
            // 
            // txtPublicKey
            // 
            txtPublicKey.BackColor = SystemColors.ActiveCaption;
            txtPublicKey.Location = new Point(247, 65);
            txtPublicKey.Margin = new Padding(2, 2, 2, 2);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.ReadOnly = true;
            txtPublicKey.Size = new Size(181, 50);
            txtPublicKey.TabIndex = 5;
            txtPublicKey.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.BackColor = SystemColors.ActiveCaption;
            txtPrivateKey.Location = new Point(959, 74);
            txtPrivateKey.Margin = new Padding(2, 2, 2, 2);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.ReadOnly = true;
            txtPrivateKey.Size = new Size(198, 50);
            txtPrivateKey.TabIndex = 6;
            txtPrivateKey.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "PublicKey";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(681, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "PrivateKey";
            // 
            // frmRSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 613);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmRSA";
            Text = "Form1";
            Load += Form1_Load;
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
