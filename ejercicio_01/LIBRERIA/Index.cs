using LIBRERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA
{
    /* EJERCICIO Nº 1
            
    Una librería necesita un programa que le permita gestionar sus ventas de sus respectivos productos.
    De cada producto se registran las siguientes características:
    •	Código de Barras
    •	Nombre del producto
    •	Descripción
    •	Precio

    Desarrollar una aplicación Orientada a Objetos utilizando VB.Net o C# que permita:
    1)	Recuperar bajo demanda la recaudación total de la librería. 
    2)	Mostrar el subtotal de la venta.
    3)	Controlar la carga de datos. */

    public partial class Index : Form
    {
        public Libreria libreria;

        public Index()
        {
            InitializeComponent();
            libreria = new Libreria();
        }

        private void ActualizarRecaudacion()
        {
            Recaudacion_lbl.Text = string.Format("${0:0.00}", libreria.Recaudacion);
        }

        private void ActualizarListBox<T>(ListBox listBox, List<T> coleccion, string mensaje = "")
        {
            listBox.Items.Clear();
            if (coleccion.Count > 0)
            {
                coleccion.ForEach(obj =>  listBox.Items.Add(obj));
            }
            else listBox.Items.Add(mensaje);
        }

        private void NuevaVenta_btn_Click(object sender, EventArgs e)
        {
            Venta_frm form = new Venta_frm(this.libreria);
            form.ShowDialog();
            ActualizarRecaudacion();
            ActualizarListBox(Ventas_listBox, libreria.Ventas, "No hay ventas.");
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ActualizarListBox(Ventas_listBox, libreria.Ventas, "No hay ventas.");
            ActualizarRecaudacion();
        }

        private void Ventas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.libreria.Ventas.Count > 0)
            {
                Venta vSeleccionada = Ventas_listBox.SelectedItem as Venta;
                ActualizarListBox(Productos_listBox, vSeleccionada.Productos);
            }
        }
    }
}
