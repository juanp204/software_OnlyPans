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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            Form1 inisiosecion = new Form1();
            inisiosecion.MdiParent = this;
            inisiosecion.Show();
            
        }
    }
}
