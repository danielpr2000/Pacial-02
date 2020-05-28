using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Business : UserControl
    {
        public Business()
        {
            InitializeComponent();
        }

        private void brcreae_Click(object sender, EventArgs e)
        {
            if (NameBusiness.Text.Equals("")|btdescription.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery("INSERT INTO BUSINESS(name, description) "+
                    $"VALUES ('{NameBusiness.Text}', '{btdescription.Text}')");
                                    

                    MessageBox.Show("Se a creado la Empresa");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah ocurrido un error");
                }
            }
        }

        private void Business_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM BUSINESS");
                dataGridView1.DataSource = dt;
                 
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }

        private void btdelite_Click(object sender, EventArgs e)
        {
            if (deleteEmpes.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                var id = deleteEmpes.Text;

                ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = {id} ");

                MessageBox.Show("Se elimino el negocio");
            }
        }
    }
}