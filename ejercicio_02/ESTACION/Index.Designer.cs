namespace ESTACION
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
            this.Surtidores_comboBox = new System.Windows.Forms.ComboBox();
            this.Surtidor_groupBox = new System.Windows.Forms.GroupBox();
            this.cantidad_lbl = new System.Windows.Forms.Label();
            this.precio_lbl = new System.Windows.Forms.Label();
            this.tipoNafta_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cargar_btn = new System.Windows.Forms.Button();
            this.Cantidad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Recargar_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Reportes_comboBox = new System.Windows.Forms.ComboBox();
            this.Reporte_listBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.recaudacion_lbl = new System.Windows.Forms.Label();
            this.SurtidorRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VerReporte_btn = new System.Windows.Forms.Button();
            this.Surtidor_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Surtidores_comboBox
            // 
            this.Surtidores_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Surtidores_comboBox.FormattingEnabled = true;
            this.Surtidores_comboBox.Location = new System.Drawing.Point(12, 25);
            this.Surtidores_comboBox.Name = "Surtidores_comboBox";
            this.Surtidores_comboBox.Size = new System.Drawing.Size(212, 21);
            this.Surtidores_comboBox.TabIndex = 0;
            this.Surtidores_comboBox.SelectedIndexChanged += new System.EventHandler(this.Surtidores_comboBox_SelectedIndexChanged);
            // 
            // Surtidor_groupBox
            // 
            this.Surtidor_groupBox.Controls.Add(this.cantidad_lbl);
            this.Surtidor_groupBox.Controls.Add(this.precio_lbl);
            this.Surtidor_groupBox.Controls.Add(this.tipoNafta_lbl);
            this.Surtidor_groupBox.Controls.Add(this.label4);
            this.Surtidor_groupBox.Controls.Add(this.label3);
            this.Surtidor_groupBox.Controls.Add(this.label2);
            this.Surtidor_groupBox.Location = new System.Drawing.Point(246, 12);
            this.Surtidor_groupBox.Name = "Surtidor_groupBox";
            this.Surtidor_groupBox.Size = new System.Drawing.Size(245, 98);
            this.Surtidor_groupBox.TabIndex = 1;
            this.Surtidor_groupBox.TabStop = false;
            this.Surtidor_groupBox.Text = "Surtidor Elegido";
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.AutoSize = true;
            this.cantidad_lbl.Location = new System.Drawing.Point(129, 71);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(80, 13);
            this.cantidad_lbl.TabIndex = 8;
            this.cantidad_lbl.Text = "cantidad_value";
            // 
            // precio_lbl
            // 
            this.precio_lbl.AutoSize = true;
            this.precio_lbl.Location = new System.Drawing.Point(85, 46);
            this.precio_lbl.Name = "precio_lbl";
            this.precio_lbl.Size = new System.Drawing.Size(68, 13);
            this.precio_lbl.TabIndex = 7;
            this.precio_lbl.Text = "precio_value";
            // 
            // tipoNafta_lbl
            // 
            this.tipoNafta_lbl.AutoSize = true;
            this.tipoNafta_lbl.Location = new System.Drawing.Point(85, 21);
            this.tipoNafta_lbl.Name = "tipoNafta_lbl";
            this.tipoNafta_lbl.Size = new System.Drawing.Size(63, 13);
            this.tipoNafta_lbl.TabIndex = 6;
            this.tipoNafta_lbl.Text = "nafta_value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Combustible disponible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de nafta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eligí un surtidor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cargar_btn);
            this.groupBox2.Controls.Add(this.Cantidad_numericUpDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(497, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargar Combustible";
            // 
            // Cargar_btn
            // 
            this.Cargar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cargar_btn.Location = new System.Drawing.Point(64, 66);
            this.Cargar_btn.Name = "Cargar_btn";
            this.Cargar_btn.Size = new System.Drawing.Size(74, 28);
            this.Cargar_btn.TabIndex = 9;
            this.Cargar_btn.Text = "Cargar";
            this.Cargar_btn.UseVisualStyleBackColor = true;
            this.Cargar_btn.Click += new System.EventHandler(this.Cargar_btn_Click);
            // 
            // Cantidad_numericUpDown
            // 
            this.Cantidad_numericUpDown.DecimalPlaces = 2;
            this.Cantidad_numericUpDown.Location = new System.Drawing.Point(64, 19);
            this.Cantidad_numericUpDown.Name = "Cantidad_numericUpDown";
            this.Cantidad_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Cantidad_numericUpDown.TabIndex = 8;
            this.Cantidad_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad:";
            // 
            // Recargar_btn
            // 
            this.Recargar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recargar_btn.Location = new System.Drawing.Point(246, 140);
            this.Recargar_btn.Name = "Recargar_btn";
            this.Recargar_btn.Size = new System.Drawing.Size(89, 37);
            this.Recargar_btn.TabIndex = 10;
            this.Recargar_btn.Text = "Recargar surtidor";
            this.Recargar_btn.UseVisualStyleBackColor = true;
            this.Recargar_btn.Click += new System.EventHandler(this.Recargar_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Reportes";
            // 
            // Reportes_comboBox
            // 
            this.Reportes_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Reportes_comboBox.FormattingEnabled = true;
            this.Reportes_comboBox.Location = new System.Drawing.Point(15, 225);
            this.Reportes_comboBox.Name = "Reportes_comboBox";
            this.Reportes_comboBox.Size = new System.Drawing.Size(212, 21);
            this.Reportes_comboBox.TabIndex = 11;
            // 
            // Reporte_listBox
            // 
            this.Reporte_listBox.FormattingEnabled = true;
            this.Reporte_listBox.Location = new System.Drawing.Point(255, 225);
            this.Reporte_listBox.Name = "Reporte_listBox";
            this.Reporte_listBox.Size = new System.Drawing.Size(320, 121);
            this.Reporte_listBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Detalles del reporte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Recaudación total:";
            // 
            // recaudacion_lbl
            // 
            this.recaudacion_lbl.AutoSize = true;
            this.recaudacion_lbl.Location = new System.Drawing.Point(606, 116);
            this.recaudacion_lbl.Name = "recaudacion_lbl";
            this.recaudacion_lbl.Size = new System.Drawing.Size(98, 13);
            this.recaudacion_lbl.TabIndex = 16;
            this.recaudacion_lbl.Text = "recaudacion_value";
            // 
            // SurtidorRecaudacion_lbl
            // 
            this.SurtidorRecaudacion_lbl.AutoSize = true;
            this.SurtidorRecaudacion_lbl.Location = new System.Drawing.Point(386, 116);
            this.SurtidorRecaudacion_lbl.Name = "SurtidorRecaudacion_lbl";
            this.SurtidorRecaudacion_lbl.Size = new System.Drawing.Size(98, 13);
            this.SurtidorRecaudacion_lbl.TabIndex = 18;
            this.SurtidorRecaudacion_lbl.Text = "recaudacion_value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Recaudación del surtidor:";
            // 
            // VerReporte_btn
            // 
            this.VerReporte_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerReporte_btn.Location = new System.Drawing.Point(15, 252);
            this.VerReporte_btn.Name = "VerReporte_btn";
            this.VerReporte_btn.Size = new System.Drawing.Size(89, 27);
            this.VerReporte_btn.TabIndex = 19;
            this.VerReporte_btn.Text = "Ver reporte";
            this.VerReporte_btn.UseVisualStyleBackColor = true;
            this.VerReporte_btn.Click += new System.EventHandler(this.VerReporte_btn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 362);
            this.Controls.Add(this.VerReporte_btn);
            this.Controls.Add(this.SurtidorRecaudacion_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.recaudacion_lbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Reporte_listBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Reportes_comboBox);
            this.Controls.Add(this.Recargar_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surtidor_groupBox);
            this.Controls.Add(this.Surtidores_comboBox);
            this.Name = "Index";
            this.Text = "ESTACIÓN SERVICIO";
            this.Load += new System.EventHandler(this.Index_Load);
            this.Surtidor_groupBox.ResumeLayout(false);
            this.Surtidor_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Surtidores_comboBox;
        private System.Windows.Forms.GroupBox Surtidor_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cantidad_lbl;
        private System.Windows.Forms.Label precio_lbl;
        private System.Windows.Forms.Label tipoNafta_lbl;
        private System.Windows.Forms.Button Cargar_btn;
        private System.Windows.Forms.NumericUpDown Cantidad_numericUpDown;
        private System.Windows.Forms.Button Recargar_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Reportes_comboBox;
        private System.Windows.Forms.ListBox Reporte_listBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label recaudacion_lbl;
        private System.Windows.Forms.Label SurtidorRecaudacion_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button VerReporte_btn;
    }
}

