namespace GUI
{
    partial class Ventas
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
            this.btn_RemoverProd = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.btnSalirV = new System.Windows.Forms.Button();
            this.grillaBoleta = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIvaTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVentaTotal = new System.Windows.Forms.TextBox();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.btnLimpair = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RemoverProd
            // 
            this.btn_RemoverProd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_RemoverProd.Location = new System.Drawing.Point(387, 267);
            this.btn_RemoverProd.Name = "btn_RemoverProd";
            this.btn_RemoverProd.Size = new System.Drawing.Size(192, 39);
            this.btn_RemoverProd.TabIndex = 4;
            this.btn_RemoverProd.Text = "<-- Remover Producto";
            this.btn_RemoverProd.UseVisualStyleBackColor = true;
            this.btn_RemoverProd.Click += new System.EventHandler(this.btn_RemoverProd_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProductos.Location = new System.Drawing.Point(388, 220);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(191, 41);
            this.btnAgregarProductos.TabIndex = 5;
            this.btnAgregarProductos.Text = "Agregar Producto -->";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            this.grillaProductos.AllowUserToResizeColumns = false;
            this.grillaProductos.AllowUserToResizeRows = false;
            this.grillaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(36, 119);
            this.grillaProductos.MultiSelect = false;
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.Size = new System.Drawing.Size(336, 309);
            this.grillaProductos.StandardTab = true;
            this.grillaProductos.TabIndex = 6;
            this.grillaProductos.VirtualMode = true;
            this.grillaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProductos_CellClick);
            // 
            // btnSalirV
            // 
            this.btnSalirV.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirV.Location = new System.Drawing.Point(388, 377);
            this.btnSalirV.Name = "btnSalirV";
            this.btnSalirV.Size = new System.Drawing.Size(191, 51);
            this.btnSalirV.TabIndex = 9;
            this.btnSalirV.Text = "Salir -->";
            this.btnSalirV.UseVisualStyleBackColor = true;
            this.btnSalirV.Click += new System.EventHandler(this.btnSalirV_Click);
            // 
            // grillaBoleta
            // 
            this.grillaBoleta.AllowUserToAddRows = false;
            this.grillaBoleta.AllowUserToDeleteRows = false;
            this.grillaBoleta.AllowUserToResizeColumns = false;
            this.grillaBoleta.AllowUserToResizeRows = false;
            this.grillaBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBoleta.Location = new System.Drawing.Point(587, 119);
            this.grillaBoleta.MultiSelect = false;
            this.grillaBoleta.Name = "grillaBoleta";
            this.grillaBoleta.ReadOnly = true;
            this.grillaBoleta.Size = new System.Drawing.Size(285, 173);
            this.grillaBoleta.StandardTab = true;
            this.grillaBoleta.TabIndex = 10;
            this.grillaBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBoleta_CellClick);
            this.grillaBoleta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBoleta_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(456, 189);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(384, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(487, 124);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(92, 20);
            this.txtProducto.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(456, 156);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(40, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(383, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(431, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "$";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(553, 156);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(26, 20);
            this.txtIva.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "+ IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(689, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "SubTotal =";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(782, 295);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(92, 20);
            this.txtSubTotal.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(715, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "IVA =";
            // 
            // txtIvaTotal
            // 
            this.txtIvaTotal.Enabled = false;
            this.txtIvaTotal.Location = new System.Drawing.Point(782, 317);
            this.txtIvaTotal.Name = "txtIvaTotal";
            this.txtIvaTotal.Size = new System.Drawing.Size(92, 20);
            this.txtIvaTotal.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(712, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total =";
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Enabled = false;
            this.txtVentaTotal.Location = new System.Drawing.Point(782, 339);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.Size = new System.Drawing.Size(92, 20);
            this.txtVentaTotal.TabIndex = 26;
            // 
            // btnBoleta
            // 
            this.btnBoleta.Enabled = false;
            this.btnBoleta.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleta.Location = new System.Drawing.Point(587, 377);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(298, 51);
            this.btnBoleta.TabIndex = 27;
            this.btnBoleta.Text = "Generar Boleta";
            this.btnBoleta.UseVisualStyleBackColor = true;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // btnLimpair
            // 
            this.btnLimpair.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpair.Location = new System.Drawing.Point(388, 312);
            this.btnLimpair.Name = "btnLimpair";
            this.btnLimpair.Size = new System.Drawing.Size(191, 39);
            this.btnLimpair.TabIndex = 28;
            this.btnLimpair.Text = "Limpiar";
            this.btnLimpair.UseVisualStyleBackColor = true;
            this.btnLimpair.Click += new System.EventHandler(this.btnLimpair_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 33);
            this.label11.TabIndex = 29;
            this.label11.Text = "MODULO VENTAS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema San Isidro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "De Venta, Compra e Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtidProd
            // 
            this.txtidProd.Enabled = false;
            this.txtidProd.Location = new System.Drawing.Point(456, 124);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(25, 20);
            this.txtidProd.TabIndex = 30;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 440);
            this.Controls.Add(this.txtidProd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpair);
            this.Controls.Add(this.btnBoleta);
            this.Controls.Add(this.txtVentaTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIvaTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.grillaBoleta);
            this.Controls.Add(this.btnSalirV);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.btn_RemoverProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_RemoverProd;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Button btnSalirV;
        private System.Windows.Forms.DataGridView grillaBoleta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIvaTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVentaTotal;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Button btnLimpair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidProd;
    }
}