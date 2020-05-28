using System;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals("")||textBoxPass.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    var valido = ConnectionDB.ExecuteQuery(
                        $"SELECT * FROM APPUSER WHERE username ='{textBoxUser.Text}' AND password ='{textBoxPass.Text}'");

                    if (valido.Rows.Count == 1)
                    {

                        if (valido.Rows[0][4].ToString().Equals("True"))
                        {

                            new PanelAdmin(valido.Rows[0][0].ToString(), valido.Rows[0][4].ToString()
                            ,valido.Rows[0][3].ToString()).Show();

                        }
                        else if (valido.Rows[0][4].ToString().Equals("False"))
                        {
                            new PanelNormalUser(valido.Rows[0][0].ToString(), valido.Rows[0][4].ToString()).Show();

                        }

                    }
                    else
                    {
                        MessageBox.Show("El ususario o la contraseña no es valido");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah ocurrido un error");
                }
            }
        }
        
    }
}
