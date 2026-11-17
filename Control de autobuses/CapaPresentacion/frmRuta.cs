using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Control_de_autobuses
{
    public partial class frmRuta : Form
    {
        CapaNegocio objNegocio = new CapaNegocio();
        private int idSeleccionado = 0;
        public frmRuta()
        {
            InitializeComponent();
        }

        private void frmRuta_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            cmbEstado.Items.AddRange(new string[] { "Activa", "Inactiva"});
            dgvRuta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuta.Columns["Descripcion"].FillWeight = 200;
        }
        private void ActualizarGrid()
        {
            dgvRuta.DataSource = null;
            dgvRuta.DataSource = objNegocio.ListadoRutas();
            if (dgvRuta.Columns["IdRuta"] != null) dgvRuta.Columns["IdRuta"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Ruta nueva = new CapaEntidades.Ruta
                {
                    NombreRuta = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Estado = cmbEstado.Text
                };
                objNegocio.RegistrarRuta(nueva);
                MessageBox.Show("Ruta guardada correctamente");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Ruta edit = new CapaEntidades.Ruta
                {
                    IdRuta = idSeleccionado,
                    NombreRuta = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Estado = cmbEstado.Text
                };
                objNegocio.ActualizarRuta(edit);
                MessageBox.Show("Ruta actualizada");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objNegocio.EliminarRuta(txtNombre.Text);
            ActualizarGrid();
            MessageBox.Show("Registro eliminado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            cmbEstado.SelectedIndex = -1;
            idSeleccionado = 0;
        }

        private void dgvRuta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvRuta.Rows[e.RowIndex].Cells["IdRuta"].Value);
                txtNombre.Text = dgvRuta.Rows[e.RowIndex].Cells["NombreRuta"].Value.ToString();
                txtDescripcion.Text = dgvRuta.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                cmbEstado.Text = dgvRuta.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            }
        }
    }
}
