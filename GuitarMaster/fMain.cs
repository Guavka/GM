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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Century Gothic", 9);  
         }
       
        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    label1.Font = new Font(label1.Font.FontFamily, 110, label1.Font.Style);
        //}

        private void bMain_Click(object sender, EventArgs e)
        {
            Form f = new fMain();
            f.Show();
            this.Hide();
        }

        private void bLesson_Click_1(object sender, EventArgs e)
        {
            Form f = new fLesson();
            f.Show();
            this.Hide();
        }

        private void bSong_Click_1(object sender, EventArgs e)
        {
            Form f = new fSong();
            f.Show();
            this.Hide();
        }

       
               

        
    }
}
