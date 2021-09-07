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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void rbtnaliñado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double cantidadaliñado, cantidadnoaliñado, cantidadespecial, totalaliñado, totalnoaliñado, totalespecial, Totalventa;
            cantidadaliñado = Convert.ToDouble(txtaliñado.Text);
            cantidadnoaliñado = Convert.ToDouble(txtnoaliñado.Text);
            cantidadespecial = Convert.ToDouble(txtespecial.Text);
            totalaliñado = cantidadaliñado * 1000;
            totalnoaliñado = cantidadnoaliñado * 500;
            totalespecial = cantidadespecial * 2000;
            Totalventa = (totalaliñado+totalespecial+totalnoaliñado);

            rtxtresultado.Text = rtxtresultado.Text + "nombre: "+ txtnombre.Text+"\ncedula: "+txtcedula.Text+"\n";
            if (rbtnaliñado.Checked == true)
            {
                rtxtresultado.Text = rtxtresultado.Text + "pan aliñado: " + "  cantidad: " + txtaliñado.Text + "Total : " + totalaliñado;
            }
            if (rbtnnoaliñado.Checked == true)
            {
                rtxtresultado.Text = rtxtresultado.Text + "pan aliñado: " + "  cantidad: " + txtnoaliñado.Text + "Total : " + totalnoaliñado;
            }
            if (rbtnaliñado.Checked == true)
            {
                rtxtresultado.Text = rtxtresultado.Text + "pan aliñado:  cantidad: " + txtespecial.Text + "Total : " + totalespecial;
            }
            rtxtresultado.Text = rtxtresultado.Text + "\nTotal: " + Totalventa;
        }
    }
}
