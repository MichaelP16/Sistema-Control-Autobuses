using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_de_autobuses.Formularios
{
    public partial class frmRegistroAsignaciones : Form
    {
        private CapaNegocio objNegocio = new CapaNegocio();
        int idSeleccionado = 0;

        public frmRegistroAsignaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbChofer.SelectedValue == null || cmbAutobus.SelectedValue == null || cmbRuta.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idC = Convert.ToInt32(cmbChofer.SelectedValue);
                int idA = Convert.ToInt32(cmbAutobus.SelectedValue);
                int idR = Convert.ToInt32(cmbRuta.SelectedValue);
                DateTime fecha = dptFecha.Value;
                string hora = cmbHora.Text;

                if (objNegocio.ValidarDisponibilidad(idC, idA, fecha, hora))
                {
                    MessageBox.Show("¡Cruce detectado! Este chofer o autobús ya están ocupados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = CapaNegocio.SesionActual.UsuarioLogueado;

                if (user.Rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase))
                {
                    objNegocio.GuardarSeleccionPersonal(user.IdUsuario, idC, idA, idR, fecha, hora);
                    MessageBox.Show("Selección personal guardada con éxito.");
                }
                else
                {
                    objNegocio.GuardarAsignacion(idC, idA, idR, fecha, hora);
                    MessageBox.Show("Asignación general guardada por el Administrador.");
                }

                ActualizarGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrid()
        {
            try
            {
                DataTable dt = objNegocio.ObtenerDatosGrid();

                dgvAsignaciones.DataSource = dt;

                dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void CargarCombos()
        {
            try
            {
                cmbChofer.DisplayMember = "Nombre";
                cmbChofer.ValueMember = "IdChofer";
                cmbChofer.DataSource = objNegocio.ListarChoferes();

                cmbAutobus.DisplayMember = "Modelo";
                cmbAutobus.ValueMember = "IdAutobus";
                cmbAutobus.DataSource = objNegocio.ListarAutobuses();

                cmbRuta.DisplayMember = "NombreRuta";
                cmbRuta.ValueMember = "IdRuta";
                cmbRuta.DataSource = objNegocio.ListarRutas();

                cmbChofer.SelectedIndex = -1;
                cmbAutobus.SelectedIndex = -1;
                cmbRuta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los selectores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegistroAsignaciones_Load(object sender, EventArgs e)
        {
            try
            {
                cmbChofer.DisplayMember = "Nombre";
                cmbChofer.ValueMember = "IdChofer";
                cmbChofer.DataSource = objNegocio.ListarChoferes();

                cmbAutobus.DisplayMember = "Modelo";
                cmbAutobus.ValueMember = "IdAutobus";
                cmbAutobus.DataSource = objNegocio.ListarAutobuses();

                cmbRuta.DisplayMember = "NombreRuta";
                cmbRuta.ValueMember = "IdRuta";
                cmbRuta.DataSource = objNegocio.ListarRutas();

                cmbHora.Items.Clear();
                cmbHora.Items.Add("06:00");
                cmbHora.Items.Add("08:00");
                cmbHora.Items.Add("10:00");
                cmbHora.Items.Add("12:00");
                cmbHora.Items.Add("14:00");
                cmbHora.Items.Add("16:00");
                cmbHora.Items.Add("18:00");

                cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;

                if (cmbHora.Items.Count > 0) cmbHora.SelectedIndex = 0;

                ActualizarGrid();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbChofer.SelectedIndex = -1;
            cmbAutobus.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            dptFecha.Value = DateTime.Now;
            cmbHora.SelectedIndex = -1;
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

        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvAsignaciones.Rows[e.RowIndex].Cells[0].Value);

                cmbChofer.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["Chofer"].Value.ToString();
                cmbAutobus.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["Autobus"].Value.ToString();
                cmbRuta.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();
                cmbHora.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["Hora"].Value.ToString();

                MessageBox.Show("Registro seleccionado. ID: " + idSeleccionado);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Seleccione un registro de la tabla."); return; }

            DialogResult result = MessageBox.Show("¿Está seguro de borrar este registro?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                objNegocio.Borrar(idSeleccionado);
                ActualizarGrid();
                idSeleccionado = 0;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Seleccione un registro para editar."); return; }

            try
            {
                int idC = (int)cmbChofer.SelectedValue;
                int idA = (int)cmbAutobus.SelectedValue;
                int idR = (int)cmbRuta.SelectedValue;
                DateTime fecha = dptFecha.Value;
                string hora = cmbHora.Text;

                if (objNegocio.ValidarDisponibilidad(idC, idA, fecha, hora))
                {
                    MessageBox.Show("Cruce detectado. No se puede editar a esa hora.");
                    return;
                }

                objNegocio.Editar(idSeleccionado, idC, idA, idR, fecha, hora);
                MessageBox.Show("Registro actualizado correctamente.");
                ActualizarGrid();
                idSeleccionado = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
