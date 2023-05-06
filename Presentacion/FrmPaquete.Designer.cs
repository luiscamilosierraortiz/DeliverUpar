namespace Presentacion
{
    partial class FrmPaquete
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcionPaquete = new System.Windows.Forms.TextBox();
            this.txtDimensionPaqute = new System.Windows.Forms.TextBox();
            this.txtPesoPaquete = new System.Windows.Forms.TextBox();
            this.txtIdPaquete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarPaquete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRemitente = new System.Windows.Forms.Panel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoPaquete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelRemitente.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
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
            // txtDescripcionPaquete
            // 
            this.txtDescripcionPaquete.Location = new System.Drawing.Point(171, 335);
            this.txtDescripcionPaquete.Name = "txtDescripcionPaquete";
            this.txtDescripcionPaquete.Size = new System.Drawing.Size(150, 20);
            this.txtDescripcionPaquete.TabIndex = 12;
            // 
            // txtDimensionPaqute
            // 
            this.txtDimensionPaqute.Location = new System.Drawing.Point(171, 283);
            this.txtDimensionPaqute.Name = "txtDimensionPaqute";
            this.txtDimensionPaqute.Size = new System.Drawing.Size(150, 20);
            this.txtDimensionPaqute.TabIndex = 11;
            // 
            // txtPesoPaquete
            // 
            this.txtPesoPaquete.Location = new System.Drawing.Point(171, 238);
            this.txtPesoPaquete.Name = "txtPesoPaquete";
            this.txtPesoPaquete.Size = new System.Drawing.Size(150, 20);
            this.txtPesoPaquete.TabIndex = 10;
            // 
            // txtIdPaquete
            // 
            this.txtIdPaquete.Enabled = false;
            this.txtIdPaquete.Location = new System.Drawing.Point(113, 143);
            this.txtIdPaquete.Name = "txtIdPaquete";
            this.txtIdPaquete.Size = new System.Drawing.Size(71, 20);
            this.txtIdPaquete.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(9, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // btnRegistrarPaquete
            // 
            this.btnRegistrarPaquete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarPaquete.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPaquete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrarPaquete.Location = new System.Drawing.Point(439, 240);
            this.btnRegistrarPaquete.Name = "btnRegistrarPaquete";
            this.btnRegistrarPaquete.Size = new System.Drawing.Size(115, 46);
            this.btnRegistrarPaquete.TabIndex = 2;
            this.btnRegistrarPaquete.Text = "Registrar";
            this.btnRegistrarPaquete.UseVisualStyleBackColor = false;
            this.btnRegistrarPaquete.Click += new System.EventHandler(this.btnRegistrarPaquete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(9, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dimension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(9, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso(kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Paquete";
            // 
            // panelRemitente
            // 
            this.panelRemitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRemitente.Controls.Add(this.txtIdCliente);
            this.panelRemitente.Controls.Add(this.label17);
            this.panelRemitente.Controls.Add(this.dateTime);
            this.panelRemitente.Controls.Add(this.cbxTipoPaquete);
            this.panelRemitente.Controls.Add(this.label15);
            this.panelRemitente.Controls.Add(this.txtDescripcionPaquete);
            this.panelRemitente.Controls.Add(this.txtDimensionPaqute);
            this.panelRemitente.Controls.Add(this.txtPesoPaquete);
            this.panelRemitente.Controls.Add(this.txtIdPaquete);
            this.panelRemitente.Controls.Add(this.label5);
            this.panelRemitente.Controls.Add(this.label4);
            this.panelRemitente.Controls.Add(this.label3);
            this.panelRemitente.Controls.Add(this.label2);
            this.panelRemitente.Controls.Add(this.label1);
            this.panelRemitente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRemitente.Location = new System.Drawing.Point(0, 0);
            this.panelRemitente.Name = "panelRemitente";
            this.panelRemitente.Size = new System.Drawing.Size(360, 468);
            this.panelRemitente.TabIndex = 0;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(220, 143);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(43, 20);
            this.txtIdCliente.TabIndex = 19;
            this.txtIdCliente.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(13, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Fecha";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(171, 377);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(104, 20);
            this.dateTime.TabIndex = 17;
            // 
            // cbxTipoPaquete
            // 
            this.cbxTipoPaquete.FormattingEnabled = true;
            this.cbxTipoPaquete.Items.AddRange(new object[] {
            "Estandar",
            "Urgente",
            "Contra Reembolso",
            "Pesado",
            "Fragil",
            "Internacional"});
            this.cbxTipoPaquete.Location = new System.Drawing.Point(171, 189);
            this.cbxTipoPaquete.Name = "cbxTipoPaquete";
            this.cbxTipoPaquete.Size = new System.Drawing.Size(150, 21);
            this.cbxTipoPaquete.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo De Paquete";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.label8);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(639, 92);
            this.panelTitulo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(215, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registro De Paquete";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Aqua;
            this.panelContenedor.Controls.Add(this.btnRegistrarPaquete);
            this.panelContenedor.Controls.Add(this.panelRemitente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(639, 468);
            this.panelContenedor.TabIndex = 3;
            // 
            // FrmPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 468);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaquete";
            this.panelRemitente.ResumeLayout(false);
            this.panelRemitente.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDescripcionPaquete;
        private System.Windows.Forms.TextBox txtDimensionPaqute;
        private System.Windows.Forms.TextBox txtPesoPaquete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarPaquete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRemitente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.TextBox txtIdPaquete;
        private System.Windows.Forms.ComboBox cbxTipoPaquete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTime;
        public System.Windows.Forms.TextBox txtIdCliente;
    }
}