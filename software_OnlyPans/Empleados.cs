﻿using System;
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


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int borrar = ("nombre: " + txtnombre.Text + "\ncedula: " + txtcedula.Text + "\n").Length;

            try
            {   
                double totalaliñado, totalnoaliñado, totalespecial, Totalventa;
                totalaliñado = 0;
                totalnoaliñado = 0;
                totalespecial = 0;

                rtxtresultado.Text = rtxtresultado.Text + "nombre: " + txtnombre.Text + "\ncedula: " + txtcedula.Text + "\n";
                if (txtnombre.Text == "" | txtcedula.Text == "")
                {
                    throw new Exception("error");
                }
                if (cbxaliñado.Checked == true)
                {
                    totalaliñado = Convert.ToDouble(txtaliñado.Text) * 1000;
                    rtxtresultado.Text = rtxtresultado.Text + "-pan aliñado:\ncantidad: " + txtaliñado.Text + " Total : " + totalaliñado+"\n";
                    borrar = borrar + ("-pan aliñado:\ncantidad: " + txtaliñado.Text + " Total : " + totalaliñado + "\n").Length;

                }
                if (cbxnoaliñado.Checked == true)
                {

                    totalnoaliñado = Convert.ToDouble(txtnoaliñado.Text) * 500;
                    rtxtresultado.Text = rtxtresultado.Text + "-pan no aliñado:\ncantidad: " + txtnoaliñado.Text + " Total : " + totalnoaliñado+"\n";
                    borrar = borrar + ("-pan no aliñado:\ncantidad: " + txtnoaliñado.Text + " Total : " + totalnoaliñado + "\n").Length;


                }
                if (cbxespecial.Checked == true)
                {
                    totalespecial = Convert.ToDouble(txtespecial.Text) * 2000;
                    rtxtresultado.Text = rtxtresultado.Text + "-pan especial:\ncantidad: " + txtespecial.Text + " Total : " + totalespecial+"\n";
                    borrar = borrar + ("-pan especial:\ncantidad: " + txtespecial.Text + " Total : " + totalespecial + "\n").Length;
                }
                Totalventa = (totalaliñado + totalespecial + totalnoaliñado);
                rtxtresultado.Text = rtxtresultado.Text + "Total: " + Totalventa + "\n\n";
                txtcedula.Text = "";
                txtnombre.Text = "";
                txtaliñado.Text = "";
                txtnoaliñado.Text = "";
                txtespecial.Text = "";
                cbxaliñado.Checked = false;
                cbxnoaliñado.Checked = false;
                cbxespecial.Checked = false;
            }
            catch(Exception)
            {
                rtxtresultado.Text = rtxtresultado.Text.Remove(rtxtresultado.Text.Length-borrar,borrar);
                MessageBox.Show("datos no validos o espacios en balnco");
            }
            
        }

        
    }
}
