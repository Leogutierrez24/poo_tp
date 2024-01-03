using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIA.Clases;

namespace LIBRERIA
{
    public partial class Venta_frm : Form
    {
        private readonly Libreria libreria;

        private Venta venta;

        public Venta_frm(Libreria libreria)
        {
            InitializeComponent();
            this.libreria = libreria;
            this.venta = new Venta(CalcularID(libreria.Ventas));
        }

        public int CalcularID(List<Venta> lista)
        {
            int resultado;
            if (lista.Count == 0)
            {
                resultado = 1;
            } else
            {
                resultado = lista.Max(venta => venta.ID);
            }
            return resultado;
        }

        private void ActualizarProductos()
        {
            Productos_listBox.Items.Clear();
            if (venta.Productos.Count > 0) venta.Productos.ForEach(producto => Productos_listBox.Items.Add(producto));
            else Productos_listBox.Items.Add("Carrito vacío.");
        }

        private void Venta_frm_Load(object sender, EventArgs e)
        {
            ActualizarProductos();
        }

        private bool ValidarInputs()
        {
            bool resultado = true;
            if (string.IsNullOrEmpty(Nombre_textBox.Text) 
                || string.IsNullOrEmpty(Codigo_textBox.Text) 
                || string.IsNullOrEmpty(Descripcion_textBox.Text)
                || Precio_numericUpDown.Value <= 0)
            {
                resultado = false;
            }
            return resultado;
        }

        private void ResetInputs()
        {
            Codigo_textBox.Text = string.Empty;
            Nombre_textBox.Text = string.Empty;
            Descripcion_textBox.Text = string.Empty;
            Precio_numericUpDown.Value = 0;
        }

        private void ActualizarTotal()
        {
            Total_lbl.Text = this.venta.Total.ToString();
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            if (ValidarInputs())
            {
                Producto p = new Producto(Codigo_textBox.Text, Nombre_textBox.Text, Descripcion_textBox.Text, (float)Precio_numericUpDown.Value);
                this.venta.AgregarProducto(p);
                ActualizarProductos();
                ActualizarTotal();
                ResetInputs();
            } else MessageBox.Show("¡Hay campos incompletos o con valores inválidos!");
        }

        private void Quitar_btn_Click(object sender, EventArgs e)
        {
            if (venta.Productos.Count != 0)
            {
                if (Productos_listBox.SelectedItems.Count > 0)
                {
                    this.venta.EliminarProducto(Productos_listBox.SelectedItem as Producto);
                    ActualizarProductos();
                    ActualizarTotal();
                }
                else MessageBox.Show("No hay producto seleccionado!!!");
            }
            else MessageBox.Show("No hay productos para eliminar!!!");
            
        }

        private void Comprar_btn_Click(object sender, EventArgs e)
        {
            if (this.venta.Productos.Count > 0)
            {
                libreria.AgregarVenta(this.venta);
                this.Close();
            }
            else MessageBox.Show("Para comprar se necesita al menos agregar un Producto!!!");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
