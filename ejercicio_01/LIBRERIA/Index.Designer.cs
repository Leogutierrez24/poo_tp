namespace LIBRERIA
{
    partial class Index
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
            this.label1 = new System.Windows.Forms.Label();
            this.NuevaVenta_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Recaudacion_lbl = new System.Windows.Forms.Label();
            this.Ventas_listBox = new System.Windows.Forms.ListBox();
            this.Productos_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // NuevaVenta_btn
            // 
            this.NuevaVenta_btn.Location = new System.Drawing.Point(12, 181);
            this.NuevaVenta_btn.Name = "NuevaVenta_btn";
            this.NuevaVenta_btn.Size = new System.Drawing.Size(88, 34);
            this.NuevaVenta_btn.TabIndex = 2;
            this.NuevaVenta_btn.Text = "Nueva venta";
            this.NuevaVenta_btn.UseVisualStyleBackColor = true;
            this.NuevaVenta_btn.Click += new System.EventHandler(this.NuevaVenta_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recaudación total:";
            // 
            // Recaudacion_lbl
            // 
            this.Recaudacion_lbl.AutoSize = true;
            this.Recaudacion_lbl.Location = new System.Drawing.Point(115, 229);
            this.Recaudacion_lbl.Name = "Recaudacion_lbl";
            this.Recaudacion_lbl.Size = new System.Drawing.Size(52, 13);
            this.Recaudacion_lbl.TabIndex = 4;
            this.Recaudacion_lbl.Text = "$0000,00";
            // 
            // Ventas_listBox
            // 
            this.Ventas_listBox.FormattingEnabled = true;
            this.Ventas_listBox.Location = new System.Drawing.Point(12, 25);
            this.Ventas_listBox.Name = "Ventas_listBox";
            this.Ventas_listBox.Size = new System.Drawing.Size(193, 147);
            this.Ventas_listBox.TabIndex = 5;
            this.Ventas_listBox.SelectedIndexChanged += new System.EventHandler(this.Ventas_listBox_SelectedIndexChanged);
            // 
            // Productos_listBox
            // 
            this.Productos_listBox.FormattingEnabled = true;
            this.Productos_listBox.Location = new System.Drawing.Point(245, 25);
            this.Productos_listBox.Name = "Productos_listBox";
            this.Productos_listBox.Size = new System.Drawing.Size(193, 147);
            this.Productos_listBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Productos";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Productos_listBox);
            this.Controls.Add(this.Ventas_listBox);
            this.Controls.Add(this.Recaudacion_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NuevaVenta_btn);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Libreria";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevaVenta_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Recaudacion_lbl;
        private System.Windows.Forms.ListBox Ventas_listBox;
        private System.Windows.Forms.ListBox Productos_listBox;
        private System.Windows.Forms.Label label4;
    }
}

