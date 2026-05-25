namespace PlayFair
{
    partial class frmPf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            blKey = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtKey = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnGiaiMa = new Button();
            btnMaHoa = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // blKey
            // 
            blKey.AutoSize = true;
            blKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blKey.Location = new Point(10, 7);
            blKey.Name = "blKey";
            blKey.Size = new Size(0, 21);
            blKey.TabIndex = 0;
            blKey.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-108, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(59, 15);
            label3.TabIndex = 18;
            label3.Text = "PublicKey";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(484, 88);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(42, 25);
            label4.TabIndex = 28;
            label4.Text = "Key";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(0, 15);
            label1.TabIndex = 29;
            // 
            // txtKey
            // 
            txtKey.BackColor = SystemColors.ActiveBorder;
            txtKey.Location = new Point(426, 121);
            txtKey.Margin = new Padding(2);
            txtKey.Multiline = true;
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(159, 38);
            txtKey.TabIndex = 26;
            txtKey.TextAlign = HorizontalAlignment.Center;
            txtKey.TextChanged += txtPublicKey_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(794, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 25;
            label2.Text = "Mã lúc sau";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(122, 85);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 24;
            label5.Text = "Mã ban đầu";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 116);
            txtInput.Margin = new Padding(2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(377, 369);
            txtInput.TabIndex = 22;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(623, 121);
            txtOutput.Margin = new Padding(2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(405, 369);
            txtOutput.TabIndex = 23;
            // 
            // btnGiaiMa
            // 
            btnGiaiMa.Location = new Point(444, 364);
            btnGiaiMa.Margin = new Padding(2);
            btnGiaiMa.Name = "btnGiaiMa";
            btnGiaiMa.Size = new Size(114, 22);
            btnGiaiMa.TabIndex = 19;
            btnGiaiMa.Text = "Giải mã";
            btnGiaiMa.UseVisualStyleBackColor = true;
            btnGiaiMa.Click += btnGiaiMa_Click;
            // 
            // btnMaHoa
            // 
            btnMaHoa.Location = new Point(444, 282);
            btnMaHoa.Margin = new Padding(2);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(114, 22);
            btnMaHoa.TabIndex = 20;
            btnMaHoa.Text = "Mã hóa";
            btnMaHoa.UseVisualStyleBackColor = true;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(444, 207);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(114, 22);
            button1.TabIndex = 30;
            button1.Text = "Xác Nhận Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 517);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(btnGiaiMa);
            Controls.Add(btnMaHoa);
            Controls.Add(label3);
            Controls.Add(blKey);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPf";
            Load += frmPf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blKey;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtKey;
        private Label label2;
        private Label label5;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnGiaiMa;
        private Button btnMaHoa;
        private Button button1;
    }
}