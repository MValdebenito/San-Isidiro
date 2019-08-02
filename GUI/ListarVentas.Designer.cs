namespace GUI
{
    partial class ListarVentas
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
            this.grillaVentas = new System.Windows.Forms.DataGridView();
            this.cbActivas = new System.Windows.Forms.CheckBox();
            this.cbAnuladas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaVentas
            // 
            this.grillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVentas.Location = new System.Drawing.Point(24, 117);
            this.grillaVentas.Name = "grillaVentas";
            this.grillaVentas.Size = new System.Drawing.Size(428, 267);
            this.grillaVentas.TabIndex = 0;
            // 
            // cbActivas
            // 
            this.cbActivas.AutoSize = true;
            this.cbActivas.Location = new System.Drawing.Point(45, 81);
            this.cbActivas.Name = "cbActivas";
            this.cbActivas.Size = new System.Drawing.Size(61, 17);
            this.cbActivas.TabIndex = 2;
            this.cbActivas.Text = "Activas";
            this.cbActivas.UseVisualStyleBackColor = true;
            this.cbActivas.CheckedChanged += new System.EventHandler(this.cbActivas_CheckedChanged);
            // 
            // cbAnuladas
            // 
            this.cbAnuladas.AutoSize = true;
            this.cbAnuladas.Location = new System.Drawing.Point(143, 81);
            this.cbAnuladas.Name = "cbAnuladas";
            this.cbAnuladas.Size = new System.Drawing.Size(70, 17);
            this.cbAnuladas.TabIndex = 3;
            this.cbAnuladas.Text = "Anuladas";
            this.cbAnuladas.UseVisualStyleBackColor = true;
            this.cbAnuladas.CheckedChanged += new System.EventHandler(this.cbAnuladas_CheckedChanged);
            // 
            // ListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 407);
            this.Controls.Add(this.cbAnuladas);
            this.Controls.Add(this.cbActivas);
            this.Controls.Add(this.grillaVentas);
            this.Name = "ListarVentas";
            this.Text = "ListarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaVentas;
        private System.Windows.Forms.CheckBox cbActivas;
        private System.Windows.Forms.CheckBox cbAnuladas;
    }
}