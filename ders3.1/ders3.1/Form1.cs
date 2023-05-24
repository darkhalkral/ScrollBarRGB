using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 255;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Value = 1;

            hScrollBar2.Minimum = 0;
            hScrollBar2.Maximum = 255;
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Value = 1;

            hScrollBar3.Minimum = 0;
            hScrollBar3.Maximum = 255;
            hScrollBar3.LargeChange = 1;
            hScrollBar3.Value = 1;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int toplam = 0;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            toplam= hScrollBar1.Value+hScrollBar2.Value+hScrollBar3.Value;
            textBox1.Text = (hScrollBar1.Value * 100 / toplam).ToString();
            textBox2.Text = (hScrollBar2.Value * 100 / toplam).ToString();
            textBox3.Text = (hScrollBar3.Value * 100 / toplam).ToString();
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int toplam = 0;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            toplam = hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value;
            textBox1.Text = (hScrollBar1.Value * 100 / toplam).ToString();
            textBox2.Text = (hScrollBar2.Value * 100 / toplam).ToString();
            textBox3.Text = (hScrollBar3.Value * 100 / toplam).ToString();
        }
        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int toplam = 0;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            toplam = hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value;
            textBox1.Text = (hScrollBar1.Value * 100 / toplam).ToString();
            textBox2.Text = (hScrollBar2.Value * 100 / toplam).ToString();
            textBox3.Text = (hScrollBar3.Value * 100 / toplam).ToString();
        }
        // Form üzerine 3 adet hscrollbar bir adet texbox form load edildekten sonra 1. horizantal red 2. green 3.blue
        // 3.ü aynı anda hareket ettirildiğinde rgb renk görüntülensin
        //RGB Renkleri pictureboxta görüntülerken aynı zamanda textbox1 2 ve 3te her rengin %kaçlık değeri aldığı gözüksün
    }
}
