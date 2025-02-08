namespace KargoTakip
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriGroup = new System.Windows.Forms.GroupBox();
            this.musteriTakipText = new System.Windows.Forms.MaskedTextBox();
            this.musteriIlerle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.musteriGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kargo Takip";
            // 
            // musteriGroup
            // 
            this.musteriGroup.Controls.Add(this.label2);
            this.musteriGroup.Controls.Add(this.musteriIlerle);
            this.musteriGroup.Controls.Add(this.musteriTakipText);
            this.musteriGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriGroup.Location = new System.Drawing.Point(96, 226);
            this.musteriGroup.Name = "musteriGroup";
            this.musteriGroup.Size = new System.Drawing.Size(257, 275);
            this.musteriGroup.TabIndex = 1;
            this.musteriGroup.TabStop = false;
            this.musteriGroup.Text = "Müşteri Giriş";
            // 
            // musteriTakipText
            // 
            this.musteriTakipText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musteriTakipText.Location = new System.Drawing.Point(43, 131);
            this.musteriTakipText.Mask = "000000";
            this.musteriTakipText.Name = "musteriTakipText";
            this.musteriTakipText.Size = new System.Drawing.Size(173, 31);
            this.musteriTakipText.TabIndex = 0;
            // 
            // musteriIlerle
            // 
            this.musteriIlerle.BackColor = System.Drawing.Color.Moccasin;
            this.musteriIlerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriIlerle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musteriIlerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriIlerle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriIlerle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musteriIlerle.Location = new System.Drawing.Point(3, 231);
            this.musteriIlerle.Name = "musteriIlerle";
            this.musteriIlerle.Size = new System.Drawing.Size(251, 41);
            this.musteriIlerle.TabIndex = 1;
            this.musteriIlerle.Text = "İlerle";
            this.musteriIlerle.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gönderi Takip No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Müşteri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Müşteri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(448, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musteriGroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.musteriGroup.ResumeLayout(false);
            this.musteriGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox musteriGroup;
        private System.Windows.Forms.Button musteriIlerle;
        private System.Windows.Forms.MaskedTextBox musteriTakipText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

