using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GuitarMaster
{
    public partial class less5 : Form
    {
        public less5()
        {
            InitializeComponent();
        }

        //private void Form3_Resize(object sender, EventArgs e)
        //{
        //    label1.Font = new Font(label1.Font.FontFamily, 110, label1.Font.Style);
        //}

        private void less0_Load(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Century Gothic", 9);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new fMain();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new fLesson();
            f.Show();
            this.Hide();
        }

        private void bSong_Click(object sender, EventArgs e)
        {
            Form f = new fSong();
            f.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form f = new fLesson();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new less6();
            f.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\video\Sound_DSP_1.avi";

            Form f = new GuitarMaster.lessons.VidPL(path);
            f.Show();
        }

       

     

        

       
    }
}
