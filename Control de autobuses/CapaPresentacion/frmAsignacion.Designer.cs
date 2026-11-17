namespace Control_de_autobuses
{
    partial class frmAsignacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacion));
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            dgvAsignaciones = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbChofer = new ComboBox();
            cmbAutobus = new ComboBox();
            cmbRuta = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dptFecha = new DateTimePicker();
            txtHora = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 164);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 41;
            label2.Text = "Ingrese los datos para asignar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 46, 116);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 158);
            panel1.TabIndex = 40;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Display", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(334, 34);
            label1.Name = "label1";
            label1.Size = new Size(610, 84);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Asignaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(228, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Silver;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(893, 416);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(597, 416);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(307, 416);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(872, 406);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(277, 65);
            btnLimpiar.TabIndex = 46;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Silver;
            btnBorrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(574, 406);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(292, 65);
            btnBorrar.TabIndex = 45;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(283, 406);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(285, 65);
            btnEditar.TabIndex = 44;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(3, 406);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(274, 65);
            btnGuardar.TabIndex = 43;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaciones.Location = new Point(3, 477);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.RowHeadersWidth = 62;
            dgvAsignaciones.Size = new Size(1145, 376);
            dgvAsignaciones.TabIndex = 42;
            dgvAsignaciones.CellContentClick += dgvAsignaciones_CellContentClick;
            dgvAsignaciones.CellFormatting += dgvAsignaciones_CellFormatting;
            // 
            // label3
            // 
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 207);
            label3.Name = "label3";
            label3.Size = new Size(278, 57);
            label3.TabIndex = 51;
            label3.Text = "seleccione el chofer";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 275);
            label4.Name = "label4";
            label4.Size = new Size(278, 57);
            label4.TabIndex = 52;
            label4.Text = "seleccione el autobus";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 342);
            label5.Name = "label5";
            label5.Size = new Size(278, 57);
            label5.TabIndex = 53;
            label5.Text = "seleccione la ruta";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbChofer
            // 
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(286, 222);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(309, 33);
            cmbChofer.TabIndex = 54;
            // 
            // cmbAutobus
            // 
            cmbAutobus.FormattingEnabled = true;
            cmbAutobus.Location = new Point(286, 290);
            cmbAutobus.Name = "cmbAutobus";
            cmbAutobus.Size = new Size(309, 33);
            cmbAutobus.TabIndex = 55;
            // 
            // cmbRuta
            // 
            cmbRuta.FormattingEnabled = true;
            cmbRuta.Location = new Point(286, 357);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(309, 33);
            cmbRuta.TabIndex = 56;
            // 
            // label6
            // 
            label6.BackColor = Color.RoyalBlue;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(601, 207);
            label6.Name = "label6";
            label6.Size = new Size(216, 57);
            label6.TabIndex = 57;
            label6.Text = "Fecha";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.RoyalBlue;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(601, 275);
            label7.Name = "label7";
            label7.Size = new Size(216, 57);
            label7.TabIndex = 58;
            label7.Text = "Hora";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dptFecha
            // 
            dptFecha.Location = new Point(823, 220);
            dptFecha.Name = "dptFecha";
            dptFecha.Size = new Size(326, 31);
            dptFecha.TabIndex = 59;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(823, 275);
            txtHora.Multiline = true;
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(325, 57);
            txtHora.TabIndex = 60;
            // 
            // frmAsignacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 856);
            Controls.Add(txtHora);
            Controls.Add(dptFecha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbRuta);
            Controls.Add(cmbAutobus);
            Controls.Add(cmbChofer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAsignaciones);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmAsignacion";
            Text = "frmAsignacion";
            Load += frmAsignacion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvAsignaciones;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbChofer;
        private ComboBox cmbAutobus;
        private ComboBox cmbRuta;
        private Label label6;
        private Label label7;
        private DateTimePicker dptFecha;
        private TextBox txtHora;
    }
}