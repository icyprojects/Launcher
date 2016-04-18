using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class MainForm : Form
    {
        int X0, Y0, Xmove, Ymove; // Объявляем переменные        
        bool MDown = false;



        public struct ActivePage
        {
            public bool first;
            public bool second;
        }

        ActivePage activePage;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void UpdateButtons()
        {
            if (activePage.first)
            {

                BigButton7.Visible = false;
                BigButton8.Visible = false;
            }
            else if (activePage.second)
            {

                BigButton7.Visible = true;
                BigButton8.Visible = true;
            }
        }

        private void ActivateFirstPage()
        {
            activePage.first = true;
            activePage.second = false;
            LeftPanelButton1.Image = form.Properties.Resources.select_1;
            LeftPanelButton2.Image = form.Properties.Resources.unselect_2;
            UpdateButtons();
        }

        private void ActivateSecondPage()
        {
            activePage.first = false;
            activePage.second = true;
            LeftPanelButton1.Image = form.Properties.Resources.unselect_1;
            LeftPanelButton2.Image = form.Properties.Resources.select_2;
            UpdateButtons();
        }


        private void MainLayout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void LeftPanelButton1_MouseEnter(object sender, EventArgs e)
        {
            if (!activePage.first)
            {
                LeftPanelButton1.Image = form.Properties.Resources.select_hover_1;
            }
        }

        private void LeftPanelButton1_MouseLeave(object sender, EventArgs e)
        {
            if (!activePage.first)
            {
                LeftPanelButton1.Image = form.Properties.Resources.unselect_1;
            }
        }

        private void LeftPanelButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!activePage.first)
            {
                LeftPanelButton1.Image = form.Properties.Resources.select_1;
            }
        }

        private void LeftPanelButton2_MouseUp(object sender, MouseEventArgs e)
        {
            ActivateSecondPage();
        }

        private void LeftPanelButton2_MouseEnter(object sender, EventArgs e)
        {
            if (!activePage.second)
            {
                LeftPanelButton2.Image = form.Properties.Resources.select_hover_2;
            }
        }

        private void LeftPanelButton2_MouseLeave(object sender, EventArgs e)
        {
            if (!activePage.second)
            {
                LeftPanelButton2.Image = form.Properties.Resources.unselect_2;
            }
        }

        private void LeftPanelButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!activePage.second)
            {
                LeftPanelButton2.Image = form.Properties.Resources.select_2;
            }
        }

        private void LeftPanelButton1_MouseUp(object sender, MouseEventArgs e)
        {
            ActivateFirstPage();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActivateFirstPage();
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            X0 = e.X;
            Y0 = e.Y;
            MDown = true;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (MDown == true) //если нажата кнопка мыши            
            {
                Xmove = e.X;
                Ymove = e.Y;
                this.SetDesktopLocation(this.Location.X + (Xmove - X0), this.Location.Y + (Ymove - Y0)); //задаем расположение формы на рабочем столе с помощью данной команды      
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            MDown = false;
        }
        //=====
    }
}
