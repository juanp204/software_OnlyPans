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
            if (rbtnespecial.Checked == true)
            {
                rbtnespecial.Checked = true;
            }
            if (rbtnnoaliñado.Checked == true)
            {
                rbtnespecial.Checked = true;
            }
        }
        private void rbtnnoaliñado_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbtnespecial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            try
            {
                double totalaliñado, totalnoaliñado, totalespecial, Totalventa;
                totalaliñado = 0;
                totalnoaliñado = 0;
                totalespecial = 0;

                rtxtresultado.Text = rtxtresultado.Text + "nombre: " + txtnombre.Text + "\ncedula: " + txtcedula.Text + "\n";
                if (rbtnaliñado.Checked == true)
                {
                    totalaliñado = Convert.ToDouble(txtaliñado.Text) * 1000;
                    rtxtresultado.Text = rtxtresultado.Text + "pan aliñado:  cantidad: " + txtaliñado.Text + "Total : " + totalaliñado;
                }
                if (rbtnnoaliñado.Checked == true)
                {

                    totalnoaliñado = Convert.ToDouble(txtnoaliñado.Text) * 500;
                    rtxtresultado.Text = rtxtresultado.Text + "pan no aliñado:  cantidad: " + txtnoaliñado.Text + "Total : " + totalnoaliñado;
                }
                if (rbtnespecial.Checked == true)
                {
                    totalespecial = Convert.ToDouble(txtespecial.Text) * 2000;
                    rtxtresultado.Text = rtxtresultado.Text + "pan especial:  cantidad: " + txtespecial.Text + "Total : " + totalespecial;
                }
                Totalventa = (totalaliñado + totalespecial + totalnoaliñado);
                rtxtresultado.Text = rtxtresultado.Text + "\nTotal: " + Totalventa + "\n\n";
            }
            catch(Exception)
            {
                MessageBox.Show("datos no validos o espacios en balnco");
            }
            
        }


    }
}
