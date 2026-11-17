namespace Control_de_autobuses
{
    partial class frmDasboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDasboard));
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnChofer = new Button();
            btnAsignaciones = new Button();
            btnRutas = new Button();
            btnAutobus = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 46, 116);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnChofer);
            panel1.Controls.Add(btnAsignaciones);
            panel1.Controls.Add(btnRutas);
            panel1.Controls.Add(btnAutobus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 924);
            panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkMagenta;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(104, 563);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 67);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkMagenta;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(104, 450);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkMagenta;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(104, 342);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkMagenta;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(104, 233);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnChofer
            // 
            btnChofer.BackColor = Color.DarkMagenta;
            btnChofer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChofer.ForeColor = SystemColors.Window;
            btnChofer.Location = new Point(70, 215);
            btnChofer.Name = "btnChofer";
            btnChofer.Size = new Size(349, 103);
            btnChofer.TabIndex = 5;
            btnChofer.Text = "Choferes";
            btnChofer.UseVisualStyleBackColor = false;
            btnChofer.Click += btnChofer_Click;
            // 
            // btnAsignaciones
            // 
            btnAsignaciones.BackColor = Color.DarkMagenta;
            btnAsignaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignaciones.ForeColor = SystemColors.Window;
            btnAsignaciones.Location = new Point(70, 542);
            btnAsignaciones.Name = "btnAsignaciones";
            btnAsignaciones.Size = new Size(349, 103);
            btnAsignaciones.TabIndex = 8;
            btnAsignaciones.Text = "Asignaciones";
            btnAsignaciones.UseVisualStyleBackColor = false;
            btnAsignaciones.Click += btnAsignaciones_Click;
            // 
            // btnRutas
            // 
            btnRutas.BackColor = Color.DarkMagenta;
            btnRutas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRutas.ForeColor = SystemColors.Window;
            btnRutas.Location = new Point(70, 433);
            btnRutas.Name = "btnRutas";
            btnRutas.Size = new Size(349, 103);
            btnRutas.TabIndex = 7;
            btnRutas.Text = "Rutas";
            btnRutas.UseVisualStyleBackColor = false;
            btnRutas.Click += btnRutas_Click;
            // 
            // btnAutobus
            // 
            btnAutobus.BackColor = Color.DarkMagenta;
            btnAutobus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutobus.ForeColor = SystemColors.Window;
            btnAutobus.Location = new Point(70, 324);
            btnAutobus.Name = "btnAutobus";
            btnAutobus.Size = new Size(349, 103);
            btnAutobus.TabIndex = 6;
            btnAutobus.Text = "Autobuses";
            btnAutobus.UseVisualStyleBackColor = false;
            btnAutobus.Click += btnAutobus_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(91, 151);
            label1.Name = "label1";
            label1.Size = new Size(303, 42);
            label1.TabIndex = 1;
            label1.Text = "Gestion General";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(194, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 542);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(496, 379);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // frmDasboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 926);
            Controls.Add(panel1);
            Name = "frmDasboard";
            Text = "frmDasboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAsignaciones;
        private Button btnRutas;
        private Button btnAutobus;
        private Button btnChofer;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
    }
}