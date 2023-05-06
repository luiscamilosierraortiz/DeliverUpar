namespace Presentacion
{
    partial class FrmRepartidor
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnRegistrarPaquete = new System.Windows.Forms.Button();
            this.panelRemitente = new System.Windows.Forms.Panel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.cbxTipoPaquete = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.txtIdPaquete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelRemitente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.label8);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(776, 92);
            this.panelTitulo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(284, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Envio De Paquete";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Aqua;
            this.panelContenedor.Controls.Add(this.btnRegistrarPaquete);
            this.panelContenedor.Controls.Add(this.panelRemitente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(776, 503);
            this.panelContenedor.TabIndex = 5;
            // 
            // btnRegistrarPaquete
            // 
            this.btnRegistrarPaquete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarPaquete.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPaquete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrarPaquete.Location = new System.Drawing.Point(553, 270);
            this.btnRegistrarPaquete.Name = "btnRegistrarPaquete";
            this.btnRegistrarPaquete.Size = new System.Drawing.Size(115, 46);
            this.btnRegistrarPaquete.TabIndex = 2;
            this.btnRegistrarPaquete.Text = "Entregar";
            this.btnRegistrarPaquete.UseVisualStyleBackColor = false;
            this.btnRegistrarPaquete.Click += new System.EventHandler(this.btnRegistrarPaquete_Click);
            // 
            // panelRemitente
            // 
            this.panelRemitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRemitente.Controls.Add(this.btnBuscar);
            this.panelRemitente.Controls.Add(this.txtIdCliente);
            this.panelRemitente.Controls.Add(this.cbxTipoPaquete);
            this.panelRemitente.Controls.Add(this.label15);
            this.panelRemitente.Controls.Add(this.txtNombreDestinatario);
            this.panelRemitente.Controls.Add(this.txtNombreRemitente);
            this.panelRemitente.Controls.Add(this.txtIdPaquete);
            this.panelRemitente.Controls.Add(this.label4);
            this.panelRemitente.Controls.Add(this.label3);
            this.panelRemitente.Controls.Add(this.label2);
            this.panelRemitente.Controls.Add(this.label1);
            this.panelRemitente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRemitente.Location = new System.Drawing.Point(0, 0);
            this.panelRemitente.Name = "panelRemitente";
            this.panelRemitente.Size = new System.Drawing.Size(410, 503);
            this.panelRemitente.TabIndex = 0;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(203, 175);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(43, 20);
            this.txtIdCliente.TabIndex = 19;
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
            this.cbxTipoPaquete.Location = new System.Drawing.Point(216, 221);
            this.cbxTipoPaquete.Name = "cbxTipoPaquete";
            this.cbxTipoPaquete.Size = new System.Drawing.Size(150, 21);
            this.cbxTipoPaquete.TabIndex = 9;
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
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(216, 315);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(150, 20);
            this.txtNombreDestinatario.TabIndex = 11;
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.Location = new System.Drawing.Point(216, 270);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.Size = new System.Drawing.Size(150, 20);
            this.txtNombreRemitente.TabIndex = 10;
            // 
            // txtIdPaquete
            // 
            this.txtIdPaquete.Location = new System.Drawing.Point(120, 175);
            this.txtIdPaquete.Name = "txtIdPaquete";
            this.txtIdPaquete.Size = new System.Drawing.Size(71, 20);
            this.txtIdPaquete.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(16, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre De Destinatario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre De Remitente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo De Paquete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Paquete";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Location = new System.Drawing.Point(267, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 31);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 503);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FrmRepartidor";
            this.Text = "FrmRepartidor";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelRemitente.ResumeLayout(false);
            this.panelRemitente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnRegistrarPaquete;
        private System.Windows.Forms.Panel panelRemitente;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cbxTipoPaquete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        public System.Windows.Forms.TextBox txtIdPaquete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
    }
}