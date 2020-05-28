using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            var addProduct = ConnectionDB.ExecuteQuery("SELECT idBusiness FROM BUSINESS");
            
            var productsCombo = new List<int>();

            foreach (DataRow v in addProduct.Rows)
            {
                productsCombo.Add(Convert.ToInt32(v[0]));
            }
            
            
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM PRODUCT");
                                
                dataGridView1.DataSource = dt;
                 
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
            
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            
            if (iDempresa.Text.Equals("")||nameEmpresa.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(iDempresa.Text);
                    ConnectionDB.ExecuteNonQuery("INSERT INTO PRODUCT(idBusiness, name) "+
                    $"VALUES({id} '{nameEmpresa.Text}')");

                    MessageBox.Show("Se guardo el usuario");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah ocurrido un error");
                }
            }
               
            
        }

        private void DeliteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DeliteProduct.Text);

                var dt = ConnectionDB.ExecuteQuery($" DELETE FROM PRODUCT WHERE idProduct = {id}");
                
                MessageBox.Show("Se ha eliminado");
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}