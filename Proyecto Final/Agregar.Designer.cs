
namespace Proyecto_Final
{
    partial class Agregar
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.txtPais = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpTrabajo = new System.Windows.Forms.GroupBox();
            this.txtTipoTrab = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpSeguimiento = new System.Windows.Forms.GroupBox();
            this.txtSeguimiento = new System.Windows.Forms.ComboBox();
            this.txtFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.agregarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.grpTrabajo.SuspendLayout();
            this.grpSeguimiento.SuspendLayout();
            this.grpFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpPersonal);
            this.panel1.Controls.Add(this.grpTrabajo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.grpSeguimiento);
            this.panel1.Controls.Add(this.grpFecha);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 642);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // grpPersonal
            // 
            this.grpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.grpPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpPersonal.Controls.Add(this.txtPais);
            this.grpPersonal.Controls.Add(this.txtDireccion);
            this.grpPersonal.Controls.Add(this.txtCiudad);
            this.grpPersonal.Controls.Add(this.txtDepartamento);
            this.grpPersonal.Controls.Add(this.txtCorreo);
            this.grpPersonal.Controls.Add(this.txtTelefono);
            this.grpPersonal.Controls.Add(this.lblDireccion);
            this.grpPersonal.Controls.Add(this.lblCiudad);
            this.grpPersonal.Controls.Add(this.lblDepart);
            this.grpPersonal.Controls.Add(this.lblPais);
            this.grpPersonal.Controls.Add(this.lblCorreo);
            this.grpPersonal.Controls.Add(this.lblTelefono);
            this.grpPersonal.Controls.Add(this.txtApellido);
            this.grpPersonal.Controls.Add(this.txtNombre);
            this.grpPersonal.Controls.Add(this.lblApellido);
            this.grpPersonal.Controls.Add(this.lblNombre);
            this.grpPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPersonal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.grpPersonal.Location = new System.Drawing.Point(12, 11);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(497, 573);
            this.grpPersonal.TabIndex = 11;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personal";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPais.FormattingEnabled = true;
            this.txtPais.Items.AddRange(new object[] {
            "Guatemala",
            "Mexico",
            "Estados Unidos",
            "Canada",
            "El Salvador",
            "Belice",
            "Honduras",
            "Nicaragua",
            "Costa Rica",
            "Panama"});
            this.txtPais.Location = new System.Drawing.Point(29, 274);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(146, 24);
            this.txtPais.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(256, 390);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(146, 16);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Location = new System.Drawing.Point(29, 390);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(146, 16);
            this.txtCiudad.TabIndex = 14;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Location = new System.Drawing.Point(256, 278);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(146, 16);
            this.txtDepartamento.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Location = new System.Drawing.Point(256, 163);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(146, 16);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Location = new System.Drawing.Point(29, 163);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 16);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(253, 371);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(26, 371);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 16);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(253, 255);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(102, 16);
            this.lblDepart.TabIndex = 7;
            this.lblDepart.Text = "Departamento";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(26, 255);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(253, 139);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 16);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(26, 139);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 16);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(256, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 16);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(29, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 16);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(253, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpTrabajo
            // 
            this.grpTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.grpTrabajo.Controls.Add(this.txtTipoTrab);
            this.grpTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTrabajo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrabajo.ForeColor = System.Drawing.SystemColors.Control;
            this.grpTrabajo.Location = new System.Drawing.Point(519, 11);
            this.grpTrabajo.Name = "grpTrabajo";
            this.grpTrabajo.Size = new System.Drawing.Size(259, 155);
            this.grpTrabajo.TabIndex = 12;
            this.grpTrabajo.TabStop = false;
            this.grpTrabajo.Text = "Tipo de trabajo";
            // 
            // txtTipoTrab
            // 
            this.txtTipoTrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtTipoTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTipoTrab.FormattingEnabled = true;
            this.txtTipoTrab.Items.AddRange(new object[] {
            "Mantenimiento",
            "Instalacion Industrial",
            "Instalacion Domiciliar",
            "Cotizacion",
            "Otros"});
            this.txtTipoTrab.Location = new System.Drawing.Point(53, 65);
            this.txtTipoTrab.Name = "txtTipoTrab";
            this.txtTipoTrab.Size = new System.Drawing.Size(146, 24);
            this.txtTipoTrab.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.btnCancelar.Location = new System.Drawing.Point(849, 590);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.btnAgregar.Location = new System.Drawing.Point(942, 590);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 41);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // grpSeguimiento
            // 
            this.grpSeguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.grpSeguimiento.Controls.Add(this.txtSeguimiento);
            this.grpSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSeguimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeguimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.grpSeguimiento.Location = new System.Drawing.Point(784, 11);
            this.grpSeguimiento.Name = "grpSeguimiento";
            this.grpSeguimiento.Size = new System.Drawing.Size(245, 155);
            this.grpSeguimiento.TabIndex = 15;
            this.grpSeguimiento.TabStop = false;
            this.grpSeguimiento.Text = "Seguimiento";
            // 
            // txtSeguimiento
            // 
            this.txtSeguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.txtSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSeguimiento.FormattingEnabled = true;
            this.txtSeguimiento.Items.AddRange(new object[] {
            "Activo",
            "Pendiente",
            "Terminado"});
            this.txtSeguimiento.Location = new System.Drawing.Point(45, 65);
            this.txtSeguimiento.Name = "txtSeguimiento";
            this.txtSeguimiento.Size = new System.Drawing.Size(146, 24);
            this.txtSeguimiento.TabIndex = 18;
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Location = new System.Drawing.Point(11, 152);
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Size = new System.Drawing.Size(200, 23);
            this.txtFechaCita.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Cita";
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.txtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.txtFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.txtFecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.txtFecha.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.txtFecha.Location = new System.Drawing.Point(11, 56);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 23);
            this.txtFecha.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de ingreso";
            // 
            // grpFecha
            // 
            this.grpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.grpFecha.Controls.Add(this.txtFechaCita);
            this.grpFecha.Controls.Add(this.label1);
            this.grpFecha.Controls.Add(this.txtFecha);
            this.grpFecha.Controls.Add(this.lblFecha);
            this.grpFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.grpFecha.Location = new System.Drawing.Point(519, 178);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Size = new System.Drawing.Size(510, 406);
            this.grpFecha.TabIndex = 13;
            this.grpFecha.TabStop = false;
            this.grpFecha.Text = "Fecha";
            // 
            // agregarBindingSource
            // 
            this.agregarBindingSource.DataSource = typeof(Proyecto_Final.Agregar);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1041, 644);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.panel1.ResumeLayout(false);
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpTrabajo.ResumeLayout(false);
            this.grpSeguimiento.ResumeLayout(false);
            this.grpFecha.ResumeLayout(false);
            this.grpFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.ComboBox txtPais;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpTrabajo;
        private System.Windows.Forms.ComboBox txtTipoTrab;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpSeguimiento;
        private System.Windows.Forms.ComboBox txtSeguimiento;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.DateTimePicker txtFechaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.BindingSource agregarBindingSource;
    }
}