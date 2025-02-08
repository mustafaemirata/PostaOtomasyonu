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
            this.kurumsalIlerle = new System.Windows.Forms.Button();
            this.kurumSicil = new System.Windows.Forms.TextBox();
            this.KuryeGroup = new System.Windows.Forms.GroupBox();
            this.kuryeKullaniciText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kuryeIlerle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kuryePassword = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.musteriGroup.SuspendLayout();
            this.kurumsalGropu.SuspendLayout();
            this.KuryeGroup.SuspendLayout();
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
            this.musteriGroup.BackColor = System.Drawing.Color.SkyBlue;
            this.musteriGroup.Controls.Add(this.label2);
            this.musteriGroup.Controls.Add(this.musteriIlerle);
            this.musteriGroup.Controls.Add(this.musteriTakipText);
            this.musteriGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriGroup.Location = new System.Drawing.Point(44, 171);
            this.musteriGroup.Name = "musteriGroup";
            this.musteriGroup.Size = new System.Drawing.Size(247, 245);
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
            this.musteriIlerle.Location = new System.Drawing.Point(3, 201);
            this.musteriIlerle.Name = "musteriIlerle";
            this.musteriIlerle.Size = new System.Drawing.Size(241, 41);
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
            this.kurumsalBTN.Click += new System.EventHandler(this.kurumsalBTN_Click);
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
            this.kuryeBTN.Click += new System.EventHandler(this.kuryeBTN_Click);
            // 
            // kurumsalGropu
            // 
            this.kurumsalGropu.Controls.Add(this.kurumSicil);
            this.kurumsalGropu.Controls.Add(this.label3);
            this.kurumsalGropu.Controls.Add(this.kurumsalIlerle);
            this.kurumsalGropu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumsalGropu.Location = new System.Drawing.Point(39, 171);
            this.kurumsalGropu.Name = "kurumsalGropu";
            this.kurumsalGropu.Size = new System.Drawing.Size(252, 274);
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
            // kurumsalIlerle
            // 
            this.kurumsalIlerle.BackColor = System.Drawing.Color.Moccasin;
            this.kurumsalIlerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kurumsalIlerle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kurumsalIlerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kurumsalIlerle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumsalIlerle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kurumsalIlerle.Location = new System.Drawing.Point(3, 230);
            this.kurumsalIlerle.Name = "kurumsalIlerle";
            this.kurumsalIlerle.Size = new System.Drawing.Size(246, 41);
            this.kurumsalIlerle.TabIndex = 1;
            this.kurumsalIlerle.Text = "İlerle";
            this.kurumsalIlerle.UseVisualStyleBackColor = false;
            // 
            // kurumSicil
            // 
            this.kurumSicil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kurumSicil.Location = new System.Drawing.Point(23, 79);
            this.kurumSicil.Name = "kurumSicil";
            this.kurumSicil.Size = new System.Drawing.Size(135, 31);
            this.kurumSicil.TabIndex = 3;
            // 
            // KuryeGroup
            // 
            this.KuryeGroup.BackColor = System.Drawing.Color.SkyBlue;
            this.KuryeGroup.Controls.Add(this.kuryePassword);
            this.KuryeGroup.Controls.Add(this.label5);
            this.KuryeGroup.Controls.Add(this.kuryeKullaniciText);
            this.KuryeGroup.Controls.Add(this.label4);
            this.KuryeGroup.Controls.Add(this.kuryeIlerle);
            this.KuryeGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KuryeGroup.Location = new System.Drawing.Point(39, 171);
            this.KuryeGroup.Name = "KuryeGroup";
            this.KuryeGroup.Size = new System.Drawing.Size(266, 290);
            this.KuryeGroup.TabIndex = 4;
            this.KuryeGroup.TabStop = false;
            this.KuryeGroup.Text = "Kurye Giriş";
            this.KuryeGroup.Visible = false;
            // 
            // kuryeKullaniciText
            // 
            this.kuryeKullaniciText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kuryeKullaniciText.Location = new System.Drawing.Point(23, 79);
            this.kuryeKullaniciText.Name = "kuryeKullaniciText";
            this.kuryeKullaniciText.Size = new System.Drawing.Size(164, 31);
            this.kuryeKullaniciText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kurye Kullanıcı Adı";
            // 
            // kuryeIlerle
            // 
            this.kuryeIlerle.BackColor = System.Drawing.Color.Moccasin;
            this.kuryeIlerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kuryeIlerle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kuryeIlerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuryeIlerle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kuryeIlerle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kuryeIlerle.Location = new System.Drawing.Point(3, 246);
            this.kuryeIlerle.Name = "kuryeIlerle";
            this.kuryeIlerle.Size = new System.Drawing.Size(260, 41);
            this.kuryeIlerle.TabIndex = 1;
            this.kuryeIlerle.Text = "İlerle";
            this.kuryeIlerle.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kurye Şifre";
            // 
            // kuryePassword
            // 
            this.kuryePassword.Location = new System.Drawing.Point(23, 168);
            this.kuryePassword.Mask = "********";
            this.kuryePassword.Name = "kuryePassword";
            this.kuryePassword.Size = new System.Drawing.Size(164, 31);
            this.kuryePassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(448, 543);
            this.Controls.Add(this.kurumsalGropu);
            this.Controls.Add(this.KuryeGroup);
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
            this.KuryeGroup.ResumeLayout(false);
            this.KuryeGroup.PerformLayout();
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
        private System.Windows.Forms.Button kurumsalIlerle;
        private System.Windows.Forms.GroupBox KuryeGroup;
        private System.Windows.Forms.TextBox kuryeKullaniciText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kuryeIlerle;
        private System.Windows.Forms.MaskedTextBox kuryePassword;
        private System.Windows.Forms.Label label5;
    }
}

