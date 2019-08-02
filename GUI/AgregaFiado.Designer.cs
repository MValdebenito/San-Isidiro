namespace GUI
{
    partial class AgregaFiado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rut = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFiar = new System.Windows.Forms.Button();
            this.lblTv = new System.Windows.Forms.Label();
            this.lblTf = new System.Windows.Forms.Label();
            this.lblTd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // Rut
            // 
            this.Rut.AutoSize = true;
            this.Rut.Location = new System.Drawing.Point(32, 93);
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(47, 13);
            this.Rut.TabIndex = 3;
            this.Rut.Text = "Nombre:";
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(85, 34);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(107, 20);
            this.txtBuscarC.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(198, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 20);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblRut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Rut);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscarC);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(86, 68);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(10, 13);
            this.lblRut.TabIndex = 6;
            this.lblRut.Text = "-";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(86, 116);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(10, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(86, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTd);
            this.groupBox2.Controls.Add(this.lblTf);
            this.groupBox2.Controls.Add(this.lblTv);
            this.groupBox2.Controls.Add(this.btnFiar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(277, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 165);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago Fiado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total de la Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total al Debe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Final:";
            // 
            // btnFiar
            // 
            this.btnFiar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnFiar.Location = new System.Drawing.Point(27, 106);
            this.btnFiar.Name = "btnFiar";
            this.btnFiar.Size = new System.Drawing.Size(204, 53);
            this.btnFiar.TabIndex = 3;
            this.btnFiar.Text = "Fiar";
            this.btnFiar.UseVisualStyleBackColor = true;
            this.btnFiar.Click += new System.EventHandler(this.btnFiar_Click);
            // 
            // lblTv
            // 
            this.lblTv.AutoSize = true;
            this.lblTv.Location = new System.Drawing.Point(122, 33);
            this.lblTv.Name = "lblTv";
            this.lblTv.Size = new System.Drawing.Size(10, 13);
            this.lblTv.TabIndex = 4;
            this.lblTv.Text = "-";
            // 
            // lblTf
            // 
            this.lblTf.AutoSize = true;
            this.lblTf.Location = new System.Drawing.Point(122, 80);
            this.lblTf.Name = "lblTf";
            this.lblTf.Size = new System.Drawing.Size(10, 13);
            this.lblTf.TabIndex = 5;
            this.lblTf.Text = "-";
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.Location = new System.Drawing.Point(122, 57);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(10, 13);
            this.lblTd.TabIndex = 6;
            this.lblTd.Text = "-";
            // 
            // AgregaFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregaFiado";
            this.Text = "AgregaFiado";

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rut;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblTf;
        private System.Windows.Forms.Label lblTv;
        private System.Windows.Forms.Button btnFiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}