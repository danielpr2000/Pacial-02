namespace Pacial_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.ButtonChangePass = new System.Windows.Forms.Button();
            this.login1 = new Pacial_02.Login();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (70)))),
                ((int) (((byte) (70)))), ((int) (((byte) (70)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Controls.Add(this.buttonLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonChangePass, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.login1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.986358F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09964F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.07117F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))),
                ((int) (((byte) (102)))), ((int) (((byte) (204)))));
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonLogin.Location = new System.Drawing.Point(115, 46);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(282, 63);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Iniciar sesion";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ButtonChangePass
            // 
            this.ButtonChangePass.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))),
                ((int) (((byte) (102)))), ((int) (((byte) (204)))));
            this.ButtonChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonChangePass.FlatAppearance.BorderSize = 0;
            this.ButtonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangePass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ButtonChangePass.Location = new System.Drawing.Point(403, 46);
            this.ButtonChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonChangePass.Name = "ButtonChangePass";
            this.ButtonChangePass.Size = new System.Drawing.Size(282, 63);
            this.ButtonChangePass.TabIndex = 1;
            this.ButtonChangePass.Text = "Cambiar contraseña";
            this.ButtonChangePass.UseVisualStyleBackColor = false;
            this.ButtonChangePass.Click += new System.EventHandler(this.ButtonChangePass_Click);
            // 
            // login1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.login1, 2);
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(115, 115);
            this.login1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(570, 443);
            this.login1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonChangePass;
        private System.Windows.Forms.Button buttonLogin;
        private Pacial_02.Login login1;
    }
}