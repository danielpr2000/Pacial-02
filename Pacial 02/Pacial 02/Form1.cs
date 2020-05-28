using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Form1 : Form
    {
        private UserControl current = null;
        public Form1()
        {
            InitializeComponent();
            current = login1;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new Login();
            tableLayoutPanel1.Controls.Add(current,1,2);
            tableLayoutPanel1.SetColumnSpan(current, 2);
        }

        private void ButtonChangePass_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new ChangePassword();
            tableLayoutPanel1.Controls.Add(current, 1, 2);
            tableLayoutPanel1.SetColumnSpan(current, 2);
        }
        
    }
}