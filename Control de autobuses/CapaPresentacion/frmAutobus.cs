using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Control_de_autobuses
{
    public partial class frmAutobus : Form
    {
        CapaNegocio objNegocio = new CapaNegocio();
        private int idSeleccionado = 0;
        public frmAutobus()
        {
            InitializeComponent();
        }

        private void frmAutobus_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            cmbEstado.Items.AddRange(new string[] { "Disponible", "En Mantenimiento", "Fuera de Servicio" });
            dgvAutobus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ActualizarGrid()
        {
            dgvAutobus.DataSource = null;
            dgvAutobus.DataSource = objNegocio.ListadoAutobuses();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Autobus nuevo = new CapaEntidades.Autobus
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Anio = int.Parse(txtAño.Text),
                    Placa = txtPlaca.Text,
                    Color = txtColor.Text,
                    Estado = cmbEstado.Text
                };
                objNegocio.RegistrarAutobus(nuevo);
                MessageBox.Show("Autobús guardado");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidades.Autobus edit = new CapaEntidades.Autobus
                {
                    IdAutobus = idSeleccionado,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Anio = int.Parse(txtAño.Text),
                    Placa = txtPlaca.Text,
                    Color = txtColor.Text,
                    Estado = cmbEstado.Text
                };
                objNegocio.ActualizarAutobus(edit);
                MessageBox.Show("Registro actualizado");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objNegocio.EliminarBus(txtPlaca.Text);
            ActualizarGrid();
            MessageBox.Show("Registro eliminado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMarca.Clear(); txtModelo.Clear(); txtAño.Clear();
            txtPlaca.Clear(); txtColor.Clear(); cmbEstado.SelectedIndex = -1;
            idSeleccionado = 0;
        }

        private void dgvAutobus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvAutobus.Rows[e.RowIndex].Cells["IdAutobus"].Value);
                txtMarca.Text = dgvAutobus.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                txtModelo.Text = dgvAutobus.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                txtAño.Text = dgvAutobus.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
                txtPlaca.Text = dgvAutobus.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
                txtColor.Text = dgvAutobus.Rows[e.RowIndex].Cells["Color"].Value.ToString();
                cmbEstado.Text = dgvAutobus.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            }
        }
    }
}
