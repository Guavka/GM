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
    public partial class fSong : Form
    {
        public fSong()
        {
            InitializeComponent();
        }
       
        //private void Form3_Resize(object sender, EventArgs e)
        //{
        //    label1.Font = new Font(label1.Font.FontFamily, 110, label1.Font.Style);
        //}

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
            other.Guitar test=new other.Guitar();
            test.initGuitar();
            test.play();
            foreach (ComboBox box in this.Controls)
            {
                MessageBox.Show(box.Text);
            }

        }

       

        

      

      
       

       

        
    }
}
