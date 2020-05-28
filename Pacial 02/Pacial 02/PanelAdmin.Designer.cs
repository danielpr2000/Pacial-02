using System.ComponentModel;

namespace Pacial_02
{
    partial class PanelAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btUsers = new System.Windows.Forms.Button();
            this.btNegocios = new System.Windows.Forms.Button();
            this.btProducto = new System.Windows.Forms.Button();
            this.btOrden = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.home1 = new Pacial_02.Home();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))),
                ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.home1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.2F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))),
                ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btUsers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btNegocios, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btProducto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btOrden, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63841F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63841F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63841F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63735F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.44742F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 693);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (42)))),
                ((int) (((byte) (118)))));
            this.btUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btUsers.FlatAppearance.BorderSize = 0;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.Location = new System.Drawing.Point(3, 2);
            this.btUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(234, 69);
            this.btUsers.TabIndex = 0;
            this.btUsers.Text = "Usuario";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btNegocios
            // 
            this.btNegocios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (42)))),
                ((int) (((byte) (118)))));
            this.btNegocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNegocios.FlatAppearance.BorderSize = 0;
            this.btNegocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNegocios.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btNegocios.ForeColor = System.Drawing.Color.White;
            this.btNegocios.Location = new System.Drawing.Point(3, 75);
            this.btNegocios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNegocios.Name = "btNegocios";
            this.btNegocios.Size = new System.Drawing.Size(234, 69);
            this.btNegocios.TabIndex = 1;
            this.btNegocios.Text = "Negocios";
            this.btNegocios.UseVisualStyleBackColor = false;
            this.btNegocios.Click += new System.EventHandler(this.btNegocios_Click);
            // 
            // btProducto
            // 
            this.btProducto.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (42)))),
                ((int) (((byte) (118)))));
            this.btProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btProducto.FlatAppearance.BorderSize = 0;
            this.btProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btProducto.ForeColor = System.Drawing.Color.White;
            this.btProducto.Location = new System.Drawing.Point(3, 148);
            this.btProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProducto.Name = "btProducto";
            this.btProducto.Size = new System.Drawing.Size(234, 69);
            this.btProducto.TabIndex = 2;
            this.btProducto.Text = "Productos";
            this.btProducto.UseVisualStyleBackColor = false;
            this.btProducto.Click += new System.EventHandler(this.btProducto_Click);
            // 
            // btOrden
            // 
            this.btOrden.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (42)))),
                ((int) (((byte) (118)))));
            this.btOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOrden.FlatAppearance.BorderSize = 0;
            this.btOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrden.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btOrden.ForeColor = System.Drawing.Color.White;
            this.btOrden.Location = new System.Drawing.Point(3, 221);
            this.btOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOrden.Name = "btOrden";
            this.btOrden.Size = new System.Drawing.Size(234, 69);
            this.btOrden.TabIndex = 3;
            this.btOrden.Text = "Ordenes";
            this.btOrden.UseVisualStyleBackColor = false;
            this.btOrden.Click += new System.EventHandler(this.btOrden_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))),
                ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.26297F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.9034F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74419F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelUser, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(249, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1118, 49);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(821, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(294, 42);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario: ";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(249, 57);
            this.home1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1118, 689);
            this.home1.TabIndex = 2;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btOrden;
        private System.Windows.Forms.Button btProducto;
        private System.Windows.Forms.Button btNegocios;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;
        private Pacial_02.Home home1;
    }
}