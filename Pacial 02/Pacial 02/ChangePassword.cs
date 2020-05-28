using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Pacial_02
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if (textuser.Text.Equals("")||textpassword.Text.Equals("")||textNEWP.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    var valido = ConnectionDB.ExecuteQuery(
                        $"SELECT * FROM APPUSER WHERE username ='{textuser.Text}' AND password ='{textpassword.Text}'");
                    
                    
                    if (valido.Rows.Count == 1)
                    {
                        
                        ConnectionDB.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textNEWP.Text}' WHERE idUser ='{Convert.ToInt32(valido.Rows[0][0].ToString())}' ");
                        
                        MessageBox.Show("Se ha cambiado la contrseña");
                        
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
