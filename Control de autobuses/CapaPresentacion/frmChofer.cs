using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Control_de_autobuses
{
    public partial class frmChofer : Form
    {
        private int idSeleccionado = 0;
        CapaNegocio objNegocio = new CapaNegocio();
        public frmChofer()
        {
            InitializeComponent();
        }

        private void frmChofer_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            dgvChofer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Chofer nuevoChofer = new CapaEntidades.Chofer
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    FechaNacimiento = dtpFecha.Value,
                    Estado = "Disponible"
                };

                objNegocio.RegistrarChofer(nuevoChofer);

                MessageBox.Show("Chofer registrado correctamente", "Éxito");
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ActualizarGrid()
        {
            dgvChofer.DataSource = null;
            dgvChofer.DataSource = objNegocio.ListadoChoferes();

            // Opcional: Ocultar la columna ID si no quieres que el usuario la vea
            if (dgvChofer.Columns["IdChofer"] != null)
                dgvChofer.Columns["IdChofer"].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            dtpFecha.Value = DateTime.Now;
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                objNegocio.Eliminar(txtNombre.Text.Trim());
                ActualizarGrid();
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Chofer choferEdit = new CapaEntidades.Chofer
                {
                    IdChofer = idSeleccionado, 
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    FechaNacimiento = dtpFecha.Value
                };

                objNegocio.ActualizarChofer(choferEdit);
                MessageBox.Show("Chofer editado correctamente");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvChofer.Rows[e.RowIndex].Cells["IdChofer"].Value);
                txtNombre.Text = dgvChofer.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvChofer.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtCedula.Text = dgvChofer.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(dgvChofer.Rows[e.RowIndex].Cells["FechaNacimiento"].Value);
            }
        }
    }
}
