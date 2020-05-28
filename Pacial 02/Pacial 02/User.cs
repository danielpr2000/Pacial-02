using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }


        private void User_Load(object sender, EventArgs e)
        {
             try
             {
                 var dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER");
                 dataGridView1.DataSource = dt;
                 
             }
             catch (Exception exception)
             {
                 MessageBox.Show("Ha ocurrido un problema");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                     var id = txtID.Text;

                     ConnectionDB.ExecuteNonQuery($"DELETE FROM APPUSER WHERE idUser = {id} ");

                    MessageBox.Show("Se elimino el usuario");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")||txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                var Table = ConnectionDB.ExecuteQuery(
                        $"SELECT username FROM APPUSER WHERE username ='{txtUsuario.Text}'");

                    if (Table.Rows.Count == 0)
                    {
                        if (TypeAdmi.Checked.Equals(true))
                        {

                            ConnectionDB.ExecuteNonQuery(
                                $"INSERT INTO APPUSER(fullname, username, password, userType) " +
                                $"VALUES('{txtNombre.Text}', '{txtUsuario.Text}', '{txtUsuario.Text}', {true})");

                            MessageBox.Show("se creo exitasamente");

                        }
                        else if (TypeUserN.Checked.Equals(true))
                        {
                            ConnectionDB.ExecuteNonQuery(
                                $"INSERT INTO APPUSER(fullname, username, password, userType) " +
                                $"VALUES('{txtNombre.Text}', '{txtUsuario.Text}', '{txtUsuario.Text}', {false})");

                            MessageBox.Show("Se creo exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("No selecciono ningun tipo usuario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ese usuario ya existe");
                    }
            } 
        } 
    } 
}
    