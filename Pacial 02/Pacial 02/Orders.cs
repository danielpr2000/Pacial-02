using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address"+
                " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                   " WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress "+
                "AND ad.idUser = au.idUser;");
                    
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
    
}