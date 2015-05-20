using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;


namespace GuitarMaster.lessons
{
    public partial class VidPL : Form
    {
        string PathForPLay;
        Video less;
        public VidPL(string PathVid)
        {
            InitializeComponent();
            PathForPLay = PathVid;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            less = null;
            
            try
            {
                less = new Video(PathForPLay);
            }
            catch (Exception DirectXException)
            {
                MessageBox.Show("Видео не найдено.");
            }
            finally
            {
                if (less != null)
                {
                    int height = panel1.Size.Height;
                    int width = panel1.Size.Width;
                    less.Owner = panel1;
                    panel1.Size = new Size(width, height);
                    less.Play();
                    play.Enabled = false;
                    pause.Enabled = true;
                    stop.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (less!=null)
            {
                less.Stop();
                this.Hide();
            }
            else
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (less != null)
            {
                
                    if (less.Paused)
                    {
                        less.Play();
                        pause.Text = "Пауза";
                    }
                    else
                    {
                        less.Pause();
                        pause.Text = "Возобновить";
                    }
                

            }
        }

        private void VidPL_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (less != null)
            {
                less.Stop();
                play.Enabled = true;
                stop.Enabled = false;
                pause.Enabled = false;
            }
        }
    }
}
