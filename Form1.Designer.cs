namespace Exercicio_Calculadora
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
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            foreverMaximize1 = new ReaLTaiizor.Controls.ForeverMaximize();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverForm1.SuspendLayout();
            SuspendLayout();
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(foreverClose1);
            foreverForm1.Controls.Add(foreverMaximize1);
            foreverForm1.Controls.Add(foreverMinimize1);
            foreverForm1.Dock = DockStyle.Fill;
            foreverForm1.Font = new Font("Segoe UI", 12F);
            foreverForm1.ForeverColor = Color.FromArgb(35, 168, 109);
            foreverForm1.HeaderColor = Color.FromArgb(45, 47, 49);
            foreverForm1.HeaderMaximize = false;
            foreverForm1.HeaderTextFont = new Font("Segoe UI", 12F);
            foreverForm1.Image = null;
            foreverForm1.Location = new Point(0, 0);
            foreverForm1.MinimumSize = new Size(210, 50);
            foreverForm1.Name = "foreverForm1";
            foreverForm1.Padding = new Padding(1, 51, 1, 1);
            foreverForm1.Sizable = true;
            foreverForm1.Size = new Size(384, 569);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "foreverForm1";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // foreverMinimize1
            // 
            foreverMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMinimize1.BackColor = Color.White;
            foreverMinimize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMinimize1.DefaultLocation = true;
            foreverMinimize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMinimize1.Font = new Font("Marlett", 12F);
            foreverMinimize1.Location = new Point(192, 264);
            foreverMinimize1.Name = "foreverMinimize1";
            foreverMinimize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMinimize1.Size = new Size(18, 18);
            foreverMinimize1.TabIndex = 0;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMaximize1
            // 
            foreverMaximize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMaximize1.BackColor = Color.White;
            foreverMaximize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMaximize1.DefaultLocation = true;
            foreverMaximize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMaximize1.Font = new Font("Marlett", 12F);
            foreverMaximize1.Location = new Point(208, 168);
            foreverMaximize1.Name = "foreverMaximize1";
            foreverMaximize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMaximize1.Size = new Size(18, 18);
            foreverMaximize1.TabIndex = 1;
            foreverMaximize1.Text = "foreverMaximize1";
            foreverMaximize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(248, 112);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 2;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 569);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            foreverForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMaximize foreverMaximize1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
    }
}
