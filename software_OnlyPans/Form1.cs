using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_OnlyPans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "1234" & txtusuario.Text == "admin")
            {
                Form admins = new Admins();
                admins.MdiParent = this.MdiParent;
                admins.Show();
                this.Close();
            }
            else if (txtcontraseña.Text == "4321" & txtusuario.Text == "usuario")
            {
                Form empleados = new Empleados();
                empleados.MdiParent = this.MdiParent;
                empleados.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
        }

    }
}
