using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Asdress : UserControl
    {
        public Asdress()
        {
            InitializeComponent();
        }

        private void Asdress_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("");
                dataGridView1.DataSource = dt;
                 
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}