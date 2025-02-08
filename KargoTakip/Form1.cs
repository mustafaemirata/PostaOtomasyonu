using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıçta tüm gruplar gizli olacak
            musteriGroup.Visible = false;
            kurumsalGropu.Visible = false;
            KuryeGroup.Visible = false;
        }

        private void MusteriBTN_Click(object sender, EventArgs e)
        {
            // Müşteri butonuna tıklandığında sadece müşteri grubunu aç, diğerlerini kapat
            musteriGroup.Visible = true;
            kurumsalGropu.Visible = false;
            KuryeGroup.Visible = false;
        }

        private void kuryeBTN_Click(object sender, EventArgs e)
        {
            // Kurye butonuna tıklandığında sadece kurye grubunu aç, diğerlerini kapat
            KuryeGroup.Visible = true;
            kurumsalGropu.Visible = false;
            musteriGroup.Visible = false;
        }

        private void kurumsalBTN_Click(object sender, EventArgs e)
        {
            // Kurumsal butonuna tıklandığında sadece kurumsal grubu aç, diğerlerini kapat
            kurumsalGropu.Visible = true;
            KuryeGroup.Visible = false;
            musteriGroup.Visible = false;
        }
    }
}
