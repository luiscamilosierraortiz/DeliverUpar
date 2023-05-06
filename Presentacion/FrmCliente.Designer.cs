namespace Presentacion
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefonoDestinatario = new System.Windows.Forms.TextBox();
            this.txtCiudadDestinatario = new System.Windows.Forms.TextBox();
            this.txtCodPostalDestinatario = new System.Windows.Forms.TextBox();
            this.txtDireccionDestinatario = new System.Windows.Forms.TextBox();
            this.txtIdentificacionDestinatario = new System.Windows.Forms.TextBox();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelRemitente = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefonoRemitente = new System.Windows.Forms.TextBox();
            this.txtCiudadRemitente = new System.Windows.Forms.TextBox();
            this.txtCodPostalRemitente = new System.Windows.Forms.TextBox();
            this.txtDireccionRemitente = new System.Windows.Forms.TextBox();
            this.txtIdentificacionRemitente = new System.Windows.Forms.TextBox();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRemitente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            this.panelTitulo.Controls.Add(this.label8);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(905, 93);
            this.panelTitulo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(375, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registro Cliente";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(43)))), ((int)(((byte)(112)))));
            this.panelContenedor.Controls.Add(this.button1);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelRemitente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 93);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(905, 441);
            this.panelContenedor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(411, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtTelefonoDestinatario);
            this.panel1.Controls.Add(this.txtCiudadDestinatario);
            this.panel1.Controls.Add(this.txtCodPostalDestinatario);
            this.panel1.Controls.Add(this.txtDireccionDestinatario);
            this.panel1.Controls.Add(this.txtIdentificacionDestinatario);
            this.panel1.Controls.Add(this.txtNombreDestinatario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(563, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 441);
            this.panel1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(103, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 22);
            this.label16.TabIndex = 16;
            this.label16.Text = "Datos Destinatario";
            // 
            // txtTelefonoDestinatario
            // 
            this.txtTelefonoDestinatario.Location = new System.Drawing.Point(180, 351);
            this.txtTelefonoDestinatario.Name = "txtTelefonoDestinatario";
            this.txtTelefonoDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtTelefonoDestinatario.TabIndex = 29;
            this.txtTelefonoDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtCiudadDestinatario
            // 
            this.txtCiudadDestinatario.Location = new System.Drawing.Point(180, 303);
            this.txtCiudadDestinatario.Name = "txtCiudadDestinatario";
            this.txtCiudadDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtCiudadDestinatario.TabIndex = 28;
            // 
            // txtCodPostalDestinatario
            // 
            this.txtCodPostalDestinatario.Location = new System.Drawing.Point(180, 255);
            this.txtCodPostalDestinatario.Name = "txtCodPostalDestinatario";
            this.txtCodPostalDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtCodPostalDestinatario.TabIndex = 27;
            this.txtCodPostalDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtDireccionDestinatario
            // 
            this.txtDireccionDestinatario.Location = new System.Drawing.Point(180, 203);
            this.txtDireccionDestinatario.Name = "txtDireccionDestinatario";
            this.txtDireccionDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtDireccionDestinatario.TabIndex = 26;
            // 
            // txtIdentificacionDestinatario
            // 
            this.txtIdentificacionDestinatario.Location = new System.Drawing.Point(180, 158);
            this.txtIdentificacionDestinatario.Name = "txtIdentificacionDestinatario";
            this.txtIdentificacionDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtIdentificacionDestinatario.TabIndex = 25;
            this.txtIdentificacionDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(180, 112);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtNombreDestinatario.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(21, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(20, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cuidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(18, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cod Postal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(18, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Dirección";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(18, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Identificación";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(18, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre Completo";
            // 
            // panelRemitente
            // 
            this.panelRemitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.panelRemitente.Controls.Add(this.label17);
            this.panelRemitente.Controls.Add(this.btnBuscar);
            this.panelRemitente.Controls.Add(this.label15);
            this.panelRemitente.Controls.Add(this.txtTelefonoRemitente);
            this.panelRemitente.Controls.Add(this.txtCiudadRemitente);
            this.panelRemitente.Controls.Add(this.txtCodPostalRemitente);
            this.panelRemitente.Controls.Add(this.txtDireccionRemitente);
            this.panelRemitente.Controls.Add(this.txtIdentificacionRemitente);
            this.panelRemitente.Controls.Add(this.txtNombreRemitente);
            this.panelRemitente.Controls.Add(this.txtID);
            this.panelRemitente.Controls.Add(this.label7);
            this.panelRemitente.Controls.Add(this.label6);
            this.panelRemitente.Controls.Add(this.dateTime);
            this.panelRemitente.Controls.Add(this.label5);
            this.panelRemitente.Controls.Add(this.label4);
            this.panelRemitente.Controls.Add(this.label3);
            this.panelRemitente.Controls.Add(this.label2);
            this.panelRemitente.Controls.Add(this.label1);
            this.panelRemitente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRemitente.Location = new System.Drawing.Point(0, 0);
            this.panelRemitente.Name = "panelRemitente";
            this.panelRemitente.Size = new System.Drawing.Size(360, 441);
            this.panelRemitente.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(12, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 21);
            this.label17.TabIndex = 16;
            this.label17.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Location = new System.Drawing.Point(135, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 31);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(74, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 22);
            this.label15.TabIndex = 15;
            this.label15.Text = "Datos Remitente";
            // 
            // txtTelefonoRemitente
            // 
            this.txtTelefonoRemitente.Location = new System.Drawing.Point(170, 369);
            this.txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            this.txtTelefonoRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtTelefonoRemitente.TabIndex = 14;
            this.txtTelefonoRemitente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtCiudadRemitente
            // 
            this.txtCiudadRemitente.Location = new System.Drawing.Point(170, 321);
            this.txtCiudadRemitente.Name = "txtCiudadRemitente";
            this.txtCiudadRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtCiudadRemitente.TabIndex = 13;
            // 
            // txtCodPostalRemitente
            // 
            this.txtCodPostalRemitente.Location = new System.Drawing.Point(170, 273);
            this.txtCodPostalRemitente.Name = "txtCodPostalRemitente";
            this.txtCodPostalRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtCodPostalRemitente.TabIndex = 12;
            this.txtCodPostalRemitente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtDireccionRemitente
            // 
            this.txtDireccionRemitente.Location = new System.Drawing.Point(170, 221);
            this.txtDireccionRemitente.Name = "txtDireccionRemitente";
            this.txtDireccionRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtDireccionRemitente.TabIndex = 11;
            // 
            // txtIdentificacionRemitente
            // 
            this.txtIdentificacionRemitente.Location = new System.Drawing.Point(170, 176);
            this.txtIdentificacionRemitente.Name = "txtIdentificacionRemitente";
            this.txtIdentificacionRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtIdentificacionRemitente.TabIndex = 10;
            this.txtIdentificacionRemitente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionRemitente_KeyPress);
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.Location = new System.Drawing.Point(170, 130);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtNombreRemitente.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(44, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 20);
            this.txtID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(11, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(10, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuidad";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(170, 407);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(104, 20);
            this.dateTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(8, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(8, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(8, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 534);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "Form1";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRemitente.ResumeLayout(false);
            this.panelRemitente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelRemitente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoRemitente;
        private System.Windows.Forms.TextBox txtCiudadRemitente;
        private System.Windows.Forms.TextBox txtCodPostalRemitente;
        private System.Windows.Forms.TextBox txtDireccionRemitente;
        private System.Windows.Forms.TextBox txtIdentificacionRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefonoDestinatario;
        private System.Windows.Forms.TextBox txtCiudadDestinatario;
        private System.Windows.Forms.TextBox txtCodPostalDestinatario;
        private System.Windows.Forms.TextBox txtDireccionDestinatario;
        private System.Windows.Forms.TextBox txtIdentificacionDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtID;
    }
}

