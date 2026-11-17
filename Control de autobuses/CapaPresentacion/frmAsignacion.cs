using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Control_de_autobuses.CapaEntidades;

namespace Control_de_autobuses
{
    public partial class frmAsignacion : Form
    {
        CapaNegocio objNegocio = new CapaNegocio();
        private int idSeleccionado = 0;
        public frmAsignacion()
        {
            InitializeComponent();
        }

        private void frmAsignacion_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ActualizarGrid();
        }
        private void CargarCombos()
        {
            try
            {
                cmbChofer.DataSource = objNegocio.ListadoChoferes();
                cmbChofer.DisplayMember = "Nombre";
                cmbChofer.ValueMember = "IdChofer";

                cmbAutobus.DataSource = objNegocio.ListadoAutobuses();
                cmbAutobus.DisplayMember = "Modelo";
                cmbAutobus.ValueMember = "IdAutobus";

                cmbRuta.DataSource = objNegocio.ListadoRutas();
                cmbRuta.DisplayMember = "NombreRuta";
                cmbRuta.ValueMember = "IdRuta";

                cmbChofer.SelectedIndex = -1;
                cmbAutobus.SelectedIndex = -1;
                cmbRuta.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error cargando datos: " + ex.Message); }
        }
        private void ActualizarGrid()
        {
            try
            {
                dgvAsignaciones.DataSource = objNegocio.ListadoAsignaciones();

                if (dgvAsignaciones.Columns["ID_Asignacion"] != null) dgvAsignaciones.Columns["ID_Asignacion"].Visible = false;
                if (dgvAsignaciones.Columns["ID_Chofer"] != null) dgvAsignaciones.Columns["ID_Chofer"].Visible = false;
                if (dgvAsignaciones.Columns["ID_Autobus"] != null) dgvAsignaciones.Columns["ID_Autobus"].Visible = false;
                if (dgvAsignaciones.Columns["ID_Ruta"] != null) dgvAsignaciones.Columns["ID_Ruta"].Visible = false;

                dgvAsignaciones.Columns["HoraAsignacion"].HeaderText = "Hora de Salida";
                dgvAsignaciones.Columns["FechaAsignacion"].HeaderText = "Fecha";
                dgvAsignaciones.Columns["HoraAsignacion"].Width = 150;
                dgvAsignaciones.Columns["HoraAsignacion"].DefaultCellStyle.Format = @"hh\:mm";
                dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idC = (int)cmbChofer.SelectedValue;
                int idA = (int)cmbAutobus.SelectedValue;
                int idR = (int)cmbRuta.SelectedValue;
                DateTime fecha = dptFecha.Value;
                string hora = txtHora.Text.Trim();

                if (objNegocio.ValidarDisponibilidad(idC, idA, fecha, hora))
                {
                    MessageBox.Show("¡Cruce de horario detectado! El chofer o el bus ya están asignados para esta hora.",
                                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                objNegocio.RegistrarAsignacion(idC, idA, idR, fecha, hora);

                MessageBox.Show("Asignación registrada exitosamente.");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show("Error inesperado: " + ex.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbChofer.SelectedIndex = -1;
            cmbAutobus.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            dptFecha.Value = DateTime.Now;
            txtHora.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0) { MessageBox.Show("Seleccione una asignación de la lista"); return; }

                int idC = (int)cmbChofer.SelectedValue;
                int idA = (int)cmbAutobus.SelectedValue;
                int idR = (int)cmbRuta.SelectedValue;

                objNegocio.ActualizarAsignacion(idSeleccionado, idC, idA, idR, dptFecha.Value);

                MessageBox.Show("Asignación actualizada correctamente");
                ActualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0) { MessageBox.Show("Seleccione una asignación"); return; }

                if (MessageBox.Show("¿Desea eliminar esta asignación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objNegocio.BorrarAsignacion(idSeleccionado);
                    ActualizarGrid();
                    MessageBox.Show("Asignación eliminada");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    idSeleccionado = Convert.ToInt32(dgvAsignaciones.Rows[e.RowIndex].Cells["ID_Asignacion"].Value);
                    
                    cmbChofer.SelectedValue = dgvAsignaciones.Rows[e.RowIndex].Cells["ID_Chofer"].Value;
                    cmbAutobus.SelectedValue = dgvAsignaciones.Rows[e.RowIndex].Cells["ID_Autobus"].Value;
                    cmbRuta.SelectedValue = dgvAsignaciones.Rows[e.RowIndex].Cells["ID_Ruta"].Value;
                    dptFecha.Value = Convert.ToDateTime(dgvAsignaciones.Rows[e.RowIndex].Cells["FechaAsignacion"].Value);

                    txtHora.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["HoraAsignacion"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar registro: " + ex.Message);
                }
            }
        }

        private void dgvAsignaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAsignaciones.Columns[e.ColumnIndex].Name == "HoraAsignacion" && e.Value != null)
            {
                TimeSpan hora;
                if (TimeSpan.TryParse(e.Value.ToString(), out hora))
                {
                    e.Value = hora.ToString(@"hh\:mm");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
