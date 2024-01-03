namespace LIBRERIA
{
    partial class Venta_frm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.Descripcion_lbl = new System.Windows.Forms.Label();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.Precio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Productos_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quitar_btn = new System.Windows.Forms.Button();
            this.Comprar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Descripcion_textBox);
            this.groupBox1.Controls.Add(this.Descripcion_lbl);
            this.groupBox1.Controls.Add(this.Agregar_btn);
            this.groupBox1.Controls.Add(this.Precio_numericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nombre_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Codigo_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el producto";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(6, 119);
            this.Descripcion_textBox.Multiline = true;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(188, 78);
            this.Descripcion_textBox.TabIndex = 8;
            // 
            // Descripcion_lbl
            // 
            this.Descripcion_lbl.AutoSize = true;
            this.Descripcion_lbl.Location = new System.Drawing.Point(6, 103);
            this.Descripcion_lbl.Name = "Descripcion_lbl";
            this.Descripcion_lbl.Size = new System.Drawing.Size(63, 13);
            this.Descripcion_lbl.TabIndex = 7;
            this.Descripcion_lbl.Text = "Descripción";
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Location = new System.Drawing.Point(9, 242);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(84, 38);
            this.Agregar_btn.TabIndex = 6;
            this.Agregar_btn.Text = "Agregar al carrito";
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // Precio_numericUpDown
            // 
            this.Precio_numericUpDown.DecimalPlaces = 2;
            this.Precio_numericUpDown.Location = new System.Drawing.Point(9, 216);
            this.Precio_numericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Precio_numericUpDown.Name = "Precio_numericUpDown";
            this.Precio_numericUpDown.Size = new System.Drawing.Size(185, 20);
            this.Precio_numericUpDown.TabIndex = 5;
            this.Precio_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(6, 77);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(188, 20);
            this.Nombre_textBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // Codigo_textBox
            // 
            this.Codigo_textBox.Location = new System.Drawing.Point(6, 36);
            this.Codigo_textBox.Name = "Codigo_textBox";
            this.Codigo_textBox.Size = new System.Drawing.Size(188, 20);
            this.Codigo_textBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código de barras";
            // 
            // Productos_listBox
            // 
            this.Productos_listBox.FormattingEnabled = true;
            this.Productos_listBox.Location = new System.Drawing.Point(218, 32);
            this.Productos_listBox.Name = "Productos_listBox";
            this.Productos_listBox.Size = new System.Drawing.Size(202, 134);
            this.Productos_listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carrito";
            // 
            // Quitar_btn
            // 
            this.Quitar_btn.Location = new System.Drawing.Point(218, 190);
            this.Quitar_btn.Name = "Quitar_btn";
            this.Quitar_btn.Size = new System.Drawing.Size(75, 23);
            this.Quitar_btn.TabIndex = 3;
            this.Quitar_btn.Text = "Quitar";
            this.Quitar_btn.UseVisualStyleBackColor = true;
            this.Quitar_btn.Click += new System.EventHandler(this.Quitar_btn_Click);
            // 
            // Comprar_btn
            // 
            this.Comprar_btn.Location = new System.Drawing.Point(345, 190);
            this.Comprar_btn.Name = "Comprar_btn";
            this.Comprar_btn.Size = new System.Drawing.Size(75, 23);
            this.Comprar_btn.TabIndex = 4;
            this.Comprar_btn.Text = "Comprar";
            this.Comprar_btn.UseVisualStyleBackColor = true;
            this.Comprar_btn.Click += new System.EventHandler(this.Comprar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Location = new System.Drawing.Point(258, 174);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(52, 13);
            this.Total_lbl.TabIndex = 6;
            this.Total_lbl.Text = "$0000,00";
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(345, 219);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 7;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Venta_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 317);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Total_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comprar_btn);
            this.Controls.Add(this.Quitar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productos_listBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Venta_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva venta";
            this.Load += new System.EventHandler(this.Venta_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Precio_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Codigo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Productos_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quitar_btn;
        private System.Windows.Forms.Button Comprar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.Button Agregar_btn;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.Label Descripcion_lbl;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}