namespace Control_de_autobuses
{
    partial class frmAutobus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutobus));
            dgvAutobus = new DataGridView();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            txtPlaca = new TextBox();
            txtColor = new TextBox();
            cmbEstado = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAutobus).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgvAutobus
            // 
            dgvAutobus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutobus.Location = new Point(-2, 461);
            dgvAutobus.Name = "dgvAutobus";
            dgvAutobus.RowHeadersWidth = 62;
            dgvAutobus.Size = new Size(1036, 376);
            dgvAutobus.TabIndex = 0;
            dgvAutobus.CellContentClick += dgvAutobus_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(-3, 390);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(255, 65);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(258, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(255, 65);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Silver;
            btnBorrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(519, 390);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(255, 65);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(779, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(255, 65);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 46, 116);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 158);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Display", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(292, 34);
            label1.Name = "label1";
            label1.Size = new Size(519, 84);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Autobuses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(186, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-3, 156);
            label2.Name = "label2";
            label2.Size = new Size(289, 28);
            label2.TabIndex = 0;
            label2.Text = "Ingrese los datos del autobus";
            // 
            // label3
            // 
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-3, 195);
            label3.Name = "label3";
            label3.Size = new Size(224, 57);
            label3.TabIndex = 7;
            label3.Text = "Marca";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-3, 262);
            label4.Name = "label4";
            label4.Size = new Size(224, 57);
            label4.TabIndex = 8;
            label4.Text = "Modelo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-3, 327);
            label5.Name = "label5";
            label5.Size = new Size(224, 57);
            label5.TabIndex = 9;
            label5.Text = "Año";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.RoyalBlue;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(518, 195);
            label6.Name = "label6";
            label6.Size = new Size(224, 57);
            label6.TabIndex = 10;
            label6.Text = "Placa";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.RoyalBlue;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(518, 262);
            label7.Name = "label7";
            label7.Size = new Size(224, 57);
            label7.TabIndex = 11;
            label7.Text = "Color";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.RoyalBlue;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(518, 327);
            label8.Name = "label8";
            label8.Size = new Size(224, 57);
            label8.TabIndex = 12;
            label8.Text = "Estado";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(227, 195);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(285, 57);
            txtMarca.TabIndex = 13;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(227, 262);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(285, 57);
            txtModelo.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(227, 327);
            txtAño.Multiline = true;
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(285, 57);
            txtAño.TabIndex = 15;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(748, 195);
            txtPlaca.Multiline = true;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(285, 57);
            txtPlaca.TabIndex = 16;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(748, 262);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(285, 57);
            txtColor.TabIndex = 17;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(748, 339);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(285, 33);
            cmbEstado.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 400);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(280, 400);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(544, 400);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Silver;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(803, 400);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // frmAutobus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 839);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(cmbEstado);
            Controls.Add(txtColor);
            Controls.Add(txtPlaca);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAutobus);
            Name = "frmAutobus";
            Text = "frmAutobus";
            Load += frmAutobus_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutobus).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAutobus;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnLimpiar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtAño;
        private TextBox txtPlaca;
        private TextBox txtColor;
        private ComboBox cmbEstado;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}