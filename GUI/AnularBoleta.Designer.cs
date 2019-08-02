namespace GUI
{
    partial class AnularBoleta
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
            this.grillaProdutosV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumBoleta = new System.Windows.Forms.TextBox();
            this.grillaVenta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProdutosV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProdutosV
            // 
            this.grillaProdutosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProdutosV.Enabled = false;
            this.grillaProdutosV.Location = new System.Drawing.Point(12, 207);
            this.grillaProdutosV.Name = "grillaProdutosV";
            this.grillaProdutosV.ReadOnly = true;
            this.grillaProdutosV.Size = new System.Drawing.Size(372, 155);
            this.grillaProdutosV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración de Boletas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumBoleta);
            this.groupBox1.Location = new System.Drawing.Point(402, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(19, 90);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(160, 23);
            this.btnAnular.TabIndex = 2;
            this.btnAnular.Text = "Anular Boleta";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boleta N°:";
            // 
            // txtNumBoleta
            // 
            this.txtNumBoleta.Location = new System.Drawing.Point(77, 49);
            this.txtNumBoleta.Name = "txtNumBoleta";
            this.txtNumBoleta.ReadOnly = true;
            this.txtNumBoleta.Size = new System.Drawing.Size(102, 20);
            this.txtNumBoleta.TabIndex = 0;
            // 
            // grillaVenta
            // 
            this.grillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVenta.Location = new System.Drawing.Point(12, 69);
            this.grillaVenta.Name = "grillaVenta";
            this.grillaVenta.ReadOnly = true;
            this.grillaVenta.Size = new System.Drawing.Size(372, 132);
            this.grillaVenta.TabIndex = 3;
            this.grillaVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVenta_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnularBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaProdutosV);
            this.Name = "AnularBoleta";
            this.Text = "AnularBoleta";
            this.Load += new System.EventHandler(this.AnularBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProdutosV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProdutosV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumBoleta;
        private System.Windows.Forms.DataGridView grillaVenta;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button button1;
    }
}