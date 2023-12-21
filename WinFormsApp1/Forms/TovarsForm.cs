using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Classes;
using WinFormsApp1.UserControls;

namespace WinFormsApp1.Forms
{
    public partial class TovarsForm : Form
    {
        LoginForm loginForm;
        public TovarsForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void TovarsForm_Load(object sender, EventArgs e)
        {
            SkidkaComboBox.SelectedIndex = 0;
            ShowTovars(Tovar.getTovars());
        }

        private void ShowTovars(List<Tovar> tovars)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Tovar tovar in tovars)
            {
                flowLayoutPanel1.Controls.Add(new TovarControl(tovar));
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ShowTovars(Tovar.getTovars());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (SkidkaComboBox.SelectedIndex)
            {
                case 0:
                    ShowTovars(Tovar.getTovars());
                    break;
                case 1:
                    ShowTovars(Tovar.getTovars().FindAll(t => t.skidka >= 0.01 && t.skidka <= 4.99));
                    break;
                case 2:
                    ShowTovars(Tovar.getTovars().FindAll(t => t.skidka >= 5 && t.skidka <= 9.99));
                    break;
                case 3:
                    ShowTovars(Tovar.getTovars().FindAll(t => t.skidka >= 10 && t.skidka <= 14.99));
                    break;
                default:
                    SkidkaComboBox.SelectedIndex = 0;
                    ShowTovars(Tovar.getTovars());
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTovars(Tovar.getTovars().OrderBy(t => t.name).ToList());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTovars(Tovar.getTovars().OrderBy(t => t.cost).ToList());
        }

        private void CostDownRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CostDownRadio.Checked)
            {
                ShowTovars(Tovar.getTovars().OrderBy(t => t.cost).ToList());
                NameDownRadio.Checked = false;
                NameUpRadio.Checked = false;
            }
            
        }

        private void CostUpRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CostUpRadio.Checked)
            {
                ShowTovars(Tovar.getTovars().OrderByDescending(t => t.cost).ToList());
                NameDownRadio.Checked = false;
                NameUpRadio.Checked = false;
            }
            
        }

        private void NameDownRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (NameDownRadio.Checked)
            {
                ShowTovars(Tovar.getTovars().OrderBy(t => t.name).ToList());
                CostDownRadio.Checked = false;
                CostUpRadio.Checked = false;
            }
            
        }

        private void NameUpRadio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (NameUpRadio.Checked)
            {
                ShowTovars(Tovar.getTovars().OrderByDescending(t => t.name).ToList());
                CostDownRadio.Checked = false;
                CostUpRadio.Checked = false;
            }
        }
    }
}
