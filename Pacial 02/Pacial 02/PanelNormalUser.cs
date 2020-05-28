using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class PanelNormalUser : Form
    {
        private UserControl current = null;
        public PanelNormalUser(string idser,string type)
        {
            InitializeComponent();
            current = home1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new OrdersUser();
            tableLayoutPanel1.Controls.Add(current,1,1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new Asdress();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,1);
        }
    }
}