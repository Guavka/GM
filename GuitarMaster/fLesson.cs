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
    public partial class fLesson : Form
    {
        
        public fLesson()
        {
            InitializeComponent();
           
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new less0();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new less1();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new less2();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new less3();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new less4();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new less5();
            f.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form f = new less6();
            f.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form f = new less7();
            f.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form f = new less8();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new less9();
            f.Show();
            this.Hide();
        }

       

       

       

                 

               

        
    }
}
