using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = form.Properties.Resources.cdf_hovered;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = form.Properties.Resources.cdf_normal;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = form.Properties.Resources.cdf_pressed;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = form.Properties.Resources.cdf_normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //run cdf
        }
        //=====



        // Ссылка на DT
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // run dt
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = form.Properties.Resources.dt_hovered;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = form.Properties.Resources.dt_normal;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = form.Properties.Resources.dt_pressed;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = form.Properties.Resources.dt_normal;
        }
        //=====



        //Ссылка на OFDM
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //run ofdm
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = form.Properties.Resources.ofdm_hovered;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = form.Properties.Resources.ofdm_normal;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = form.Properties.Resources.ofdm_normal;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = form.Properties.Resources.ofdm_pressed;
        }
        //=====


        // Ссылка на QAM Auto
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // run qam auto
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = form.Properties.Resources.qam_auto_hovered;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = form.Properties.Resources.qam_auto_normal;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = form.Properties.Resources.qam_auto_pressed;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = form.Properties.Resources.qam_auto_normal;
        }
        //===

        // Ссылка на qam manual
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //run qam manual
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = form.Properties.Resources.qam_manual_hovered;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = form.Properties.Resources.qam_manual_normal;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = form.Properties.Resources.qam_manual_pressed;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = form.Properties.Resources.qam_manual_normal;
        }
        //=====


        //Ссылка на SpM
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // run SpM
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = form.Properties.Resources.spectrum_hovered;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = form.Properties.Resources.spectrum_normal;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = form.Properties.Resources.spectrum_pressed;
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = form.Properties.Resources.spectrum_normal;
        }
        //=====
    }
}
