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
            this.MusteriBTN = new System.Windows.Forms.Button();
            this.kurumsalBTN = new System.Windows.Forms.Button();
            this.kuryeBTN = new System.Windows.Forms.Button();
            this.kurumsalGropu = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kurumSicil = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.musteriGroup.SuspendLayout();
            this.kurumsalGropu.SuspendLayout();
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
            this.musteriGroup.Controls.Add(this.kurumsalGropu);
            this.musteriGroup.Controls.Add(this.label2);
            this.musteriGroup.Controls.Add(this.musteriIlerle);
            this.musteriGroup.Controls.Add(this.musteriTakipText);
            this.musteriGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriGroup.Location = new System.Drawing.Point(96, 191);
            this.musteriGroup.Name = "musteriGroup";
            this.musteriGroup.Size = new System.Drawing.Size(257, 305);
            this.musteriGroup.TabIndex = 1;
            this.musteriGroup.TabStop = false;
            this.musteriGroup.Text = "Müşteri Giriş";
            this.musteriGroup.Visible = false;
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
            this.musteriIlerle.Location = new System.Drawing.Point(3, 261);
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
            // MusteriBTN
            // 
            this.MusteriBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.MusteriBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusteriBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusteriBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MusteriBTN.Location = new System.Drawing.Point(44, 107);
            this.MusteriBTN.Name = "MusteriBTN";
            this.MusteriBTN.Size = new System.Drawing.Size(112, 33);
            this.MusteriBTN.TabIndex = 2;
            this.MusteriBTN.Text = "Müşteri";
            this.MusteriBTN.UseVisualStyleBackColor = false;
            this.MusteriBTN.Click += new System.EventHandler(this.MusteriBTN_Click);
            // 
            // kurumsalBTN
            // 
            this.kurumsalBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.kurumsalBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kurumsalBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kurumsalBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumsalBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kurumsalBTN.Location = new System.Drawing.Point(163, 107);
            this.kurumsalBTN.Name = "kurumsalBTN";
            this.kurumsalBTN.Size = new System.Drawing.Size(112, 33);
            this.kurumsalBTN.TabIndex = 3;
            this.kurumsalBTN.Text = "Kurusal";
            this.kurumsalBTN.UseVisualStyleBackColor = false;
            // 
            // kuryeBTN
            // 
            this.kuryeBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.kuryeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kuryeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuryeBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kuryeBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kuryeBTN.Location = new System.Drawing.Point(281, 107);
            this.kuryeBTN.Name = "kuryeBTN";
            this.kuryeBTN.Size = new System.Drawing.Size(112, 33);
            this.kuryeBTN.TabIndex = 4;
            this.kuryeBTN.Text = "Kurye";
            this.kuryeBTN.UseVisualStyleBackColor = false;
            // 
            // kurumsalGropu
            // 
            this.kurumsalGropu.Controls.Add(this.kurumSicil);
            this.kurumsalGropu.Controls.Add(this.label3);
            this.kurumsalGropu.Controls.Add(this.button1);
            this.kurumsalGropu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumsalGropu.Location = new System.Drawing.Point(0, 0);
            this.kurumsalGropu.Name = "kurumsalGropu";
            this.kurumsalGropu.Size = new System.Drawing.Size(257, 305);
            this.kurumsalGropu.TabIndex = 3;
            this.kurumsalGropu.TabStop = false;
            this.kurumsalGropu.Text = "Kurumsal Giriş";
            this.kurumsalGropu.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kurum Sicil";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "İlerle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // kurumSicil
            // 
            this.kurumSicil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kurumSicil.Location = new System.Drawing.Point(23, 79);
            this.kurumSicil.Name = "kurumSicil";
            this.kurumSicil.Size = new System.Drawing.Size(135, 31);
            this.kurumSicil.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(448, 543);
            this.Controls.Add(this.kuryeBTN);
            this.Controls.Add(this.kurumsalBTN);
            this.Controls.Add(this.MusteriBTN);
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
            this.kurumsalGropu.ResumeLayout(false);
            this.kurumsalGropu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox musteriGroup;
        private System.Windows.Forms.Button musteriIlerle;
        private System.Windows.Forms.MaskedTextBox musteriTakipText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MusteriBTN;
        private System.Windows.Forms.Button kurumsalBTN;
        private System.Windows.Forms.Button kuryeBTN;
        private System.Windows.Forms.GroupBox kurumsalGropu;
        private System.Windows.Forms.TextBox kurumSicil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

