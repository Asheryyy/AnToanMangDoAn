namespace RSA
{
    partial class dashboard
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
            btnRSA = new Button();
            btnPlayFair = new Button();
            SuspendLayout();
            // 
            // btnRSA
            // 
            btnRSA.Location = new Point(92, 152);
            btnRSA.Name = "btnRSA";
            btnRSA.Size = new Size(206, 98);
            btnRSA.TabIndex = 0;
            btnRSA.Text = "RSA";
            btnRSA.UseVisualStyleBackColor = true;
            btnRSA.Click += button1_Click;
            // 
            // btnPlayFair
            // 
            btnPlayFair.Location = new Point(479, 152);
            btnPlayFair.Name = "btnPlayFair";
            btnPlayFair.Size = new Size(206, 98);
            btnPlayFair.TabIndex = 1;
            btnPlayFair.Text = "PlayFair";
            btnPlayFair.UseVisualStyleBackColor = true;
            btnPlayFair.Click += button2_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlayFair);
            Controls.Add(btnRSA);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRSA;
        private Button btnPlayFair;
    }
}