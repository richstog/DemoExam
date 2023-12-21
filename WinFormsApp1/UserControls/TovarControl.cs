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

namespace WinFormsApp1.UserControls
{
    public partial class TovarControl : UserControl
    {
        Tovar tovar;
        string val = " руб.";
        public TovarControl(Tovar tovar)
        {
            InitializeComponent();
            this.tovar = tovar;
        }

        private void TovarControl_Load(object sender, EventArgs e)
        {
            NameLabel.Text = tovar.name;
            BaseCostLabel.Text = tovar.cost.ToString("0.00") + val;

            if (tovar.skidka > 0)
            {
                BaseCostLabel.Font = new Font(BaseCostLabel.Font, FontStyle.Strikeout);
                NewCostLabel.Text = (tovar.cost - (tovar.cost / 100 * tovar.skidka)).ToString("0.00") + val;
                this.BackColor = Color.LightYellow;
            }
            else
            {
                NewCostLabel.Visible = false;
            }
            
            

        }
    }
}
