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

        private void MainLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_hovered;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_normal;
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_pressed;
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_normal;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseDown_1(object sender, MouseEventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_pressed;
        }

        private void closeButton_MouseUp_1(object sender, MouseEventArgs e)
        {
            closeButton.Image = form.Properties.Resources.launcher_exit_normal;
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutDownButton_MouseEnter(object sender, EventArgs e)
        {
            cutDownButton.Image = form.Properties.Resources.launcher_сutdown_hover;
        }

        private void cutDownButton_MouseLeave(object sender, EventArgs e)
        {
            cutDownButton.Image = form.Properties.Resources.launcher_сutdown_normal;
        }

        private void cutDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            cutDownButton.Image = form.Properties.Resources.launcher_сutdown_pressed;
        }

        private void cutDownButton_MouseUp(object sender, MouseEventArgs e)
        {
            cutDownButton.Image = form.Properties.Resources.launcher_сutdown_normal;
        }

        private void cutDownButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BigButton1_MouseEnter(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton1.Image = form.Properties.Resources.Button_2_hovered;
                textBox1.Text = "Программа демонстрирует алгоритм работы дельта-модулятора. Позволяет пронаблюдать " +
                                "как выглядит сигнал на выходе и как он зависит " +
                                "от частоты дискретизации и шага квантования. Есть базовые наборы входных сигналов и" +
                                " пользователь может посмотреть как как они обрабатываются.";
            }
            else
            {
                
            }
        }

        private void BigButton1_MouseLeave(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton1.Image = form.Properties.Resources.Button_2;
                textBox1.Text = "";
            }
            else
            {

            }
        }

        private void BigButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton1.Image = form.Properties.Resources.Button_2_pressed;
            }
            else
            {

            }
        }

        private void BigButton1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton1.Image = form.Properties.Resources.Button_2;
            }
            else
            {

            }
        }

        private void BigButton1_Click(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                MessageBox.Show("Запускается Дельта-модулятор");
            }
            else
            {
                
            }
        }

        private void BigButton2_MouseEnter(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton2.Image = form.Properties.Resources.button_1_hovered;
                textBox1.Text = "Программа позволяет наблюдать различные сигнальные созвездия такие как КАМ-4," +
                                " КАМ-16, 8-PSK и другие. Позволяет посмотреть амплитуду и фазу колебания," +
                                " а также само колебание, вызванное принятой входной комбинацией. " +
                                "В зависимости от того какое созвездие выбрано, меняются возможные варианты на" +
                                " входе, а также возможные колебания на выходе. ";
            }
            else
            {
                
            }
        }

        private void BigButton2_MouseLeave(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton2.Image = form.Properties.Resources.button_1;
                textBox1.Text = "";
            }
            else
            {

            }
        }

        private void BigButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton2.Image = form.Properties.Resources.Button_1_pressed;
            }
            else
            {

            }
        }

        private void BigButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton2.Image = form.Properties.Resources.button_1;
            }
            else
            {

            }
        }

        private void BigButton2_Click(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                MessageBox.Show("Запускается Формирование Сигнальных созвездий");
            }
            else
            {

            }
        }

        private void BigButton3_MouseEnter(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton3.Image = form.Properties.Resources.Button_3_hovered;
                textBox1.Text = "Программа позволяет наблюдать за процессом создания OFDM сигнала. " +
                                "Увидеть синфазную и квадратурную составляющую, а так же огибающую на выходе " +
                                "Смотреть таблицу показывающую работу по созданию OFDM сигнала," +
                                " все промежуточные действия.";
            }
            else
            {
                
            }
        }

        private void BigButton3_MouseLeave(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                BigButton3.Image = form.Properties.Resources.Button_3;
                textBox1.Text = "";
            }
            else
            {

            }
        }

        private void BigButton3_MouseDown(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton3.Image = form.Properties.Resources.Button_3_pressed;
            }
            else
            {

            }
        }

        private void BigButton3_MouseUp(object sender, MouseEventArgs e)
        {
            if (activePage.first)
            {
                BigButton3.Image = form.Properties.Resources.Button_3;
            }
            else
            {

            }
        }

        private void BigButton3_Click(object sender, EventArgs e)
        {
            if (activePage.first)
            {
                MessageBox.Show("Запускается Формирование OFDM сигнала");
            }
            else
            {

            }
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
