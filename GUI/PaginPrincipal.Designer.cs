namespace GUI
{
    partial class PaginPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnLV = new System.Windows.Forms.Button();
            this.btnAB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAP = new System.Windows.Forms.Button();
            this.btnLP = new System.Windows.Forms.Button();
            this.btnAProd = new System.Windows.Forms.Button();
            this.btnLProd = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "De Venta, Compra e Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema San Isidro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Location = new System.Drawing.Point(63, 193);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(129, 77);
            this.btn_Ventas.TabIndex = 6;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Enabled = false;
            this.btn_Proveedores.Location = new System.Drawing.Point(236, 193);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(129, 77);
            this.btn_Proveedores.TabIndex = 7;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Enabled = false;
            this.btn_Inventario.Location = new System.Drawing.Point(409, 193);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(129, 77);
            this.btn_Inventario.TabIndex = 8;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(409, 415);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(129, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir -->";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLV
            // 
            this.btnLV.Enabled = false;
            this.btnLV.Location = new System.Drawing.Point(63, 355);
            this.btnLV.Name = "btnLV";
            this.btnLV.Size = new System.Drawing.Size(129, 33);
            this.btnLV.TabIndex = 10;
            this.btnLV.Text = "Listar Ventas";
            this.btnLV.UseVisualStyleBackColor = true;
            this.btnLV.Click += new System.EventHandler(this.btnLV_Click);
            // 
            // btnAB
            // 
            this.btnAB.Location = new System.Drawing.Point(63, 311);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(129, 33);
            this.btnAB.TabIndex = 12;
            this.btnAB.Text = "Anular Boleta";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Administrar Ventas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Administrar Proveedores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Administrar Inventario:";
            // 
            // btnAP
            // 
            this.btnAP.Enabled = false;
            this.btnAP.Location = new System.Drawing.Point(236, 311);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(129, 33);
            this.btnAP.TabIndex = 16;
            this.btnAP.Text = "Anular Pedido";
            this.btnAP.UseVisualStyleBackColor = true;
            // 
            // btnLP
            // 
            this.btnLP.Enabled = false;
            this.btnLP.Location = new System.Drawing.Point(236, 355);
            this.btnLP.Name = "btnLP";
            this.btnLP.Size = new System.Drawing.Size(129, 33);
            this.btnLP.TabIndex = 17;
            this.btnLP.Text = "Listar Pedidos ";
            this.btnLP.UseVisualStyleBackColor = true;
            // 
            // btnAProd
            // 
            this.btnAProd.Enabled = false;
            this.btnAProd.Location = new System.Drawing.Point(409, 311);
            this.btnAProd.Name = "btnAProd";
            this.btnAProd.Size = new System.Drawing.Size(129, 33);
            this.btnAProd.TabIndex = 18;
            this.btnAProd.Text = "Admin. Producto";
            this.btnAProd.UseVisualStyleBackColor = true;
            // 
            // btnLProd
            // 
            this.btnLProd.Enabled = false;
            this.btnLProd.Location = new System.Drawing.Point(409, 355);
            this.btnLProd.Name = "btnLProd";
            this.btnLProd.Size = new System.Drawing.Size(129, 33);
            this.btnLProd.TabIndex = 19;
            this.btnLProd.Text = "Listar Productos";
            this.btnLProd.UseVisualStyleBackColor = true;
            // 
            // btnAC
            // 
            this.btnAC.Enabled = false;
            this.btnAC.Location = new System.Drawing.Point(409, 82);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(129, 77);
            this.btnAC.TabIndex = 20;
            this.btnAC.Text = "Administracion\r\nde Clientes";
            this.btnAC.UseVisualStyleBackColor = true;
            // 
            // PaginPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnLProd);
            this.Controls.Add(this.btnAProd);
            this.Controls.Add(this.btnLP);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAB);
            this.Controls.Add(this.btnLV);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Inventario);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_Ventas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaginPrincipal";
            this.Text = "PaginPrincipal";
            this.Load += new System.EventHandler(this.PaginPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnLV;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Button btnLP;
        private System.Windows.Forms.Button btnAProd;
        private System.Windows.Forms.Button btnLProd;
        private System.Windows.Forms.Button btnAC;
    }
}