using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Control_de_autobuses
{
    public partial class frmDasboard : Form
    {
        public frmDasboard()
        {
            InitializeComponent();
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            frmChofer formularioChofer = new frmChofer();
            formularioChofer.ShowDialog();
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            frmAutobus formularioAutobus = new frmAutobus();
            formularioAutobus.ShowDialog();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            frmRuta formularioRuta = new frmRuta();
            formularioRuta.ShowDialog();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            frmAsignacion formularioAsignacion = new frmAsignacion();
            formularioAsignacion.ShowDialog();
        }
    }
}
