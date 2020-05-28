using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Pacial_02
{
    
    public partial class PanelAdmin : Form
    {
        private UserControl current = null;
        public PanelAdmin(string iduser,string type,string NombreUsuario)
        {
            InitializeComponent();
            labelUser.Text += NombreUsuario;
            current = home1;
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new User();
            tableLayoutPanel1.Controls.Add(current,1,1);
        }
        private void btNegocios_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new Business();
            tableLayoutPanel1.Controls.Add(current,1,1);
        }
        
        private void btProducto_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new Products();
            tableLayoutPanel1.Controls.Add(current,1,1);
        }

        private void btOrden_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new Orders();
            tableLayoutPanel1.Controls.Add(current,1,1);
        }

        
    }
}