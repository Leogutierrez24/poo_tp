using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESTACION.Clases;

namespace ESTACION
{
    /* EJERCICIO Nº 2

    Una estación de servicio necesita un programa que le permita administrar sus ventas, 
    para ello cuenta con 3 surtidores, cada surtidor en su interior estará cargado con 1 tipo de nafta.
    Los tipos de naftas junto con sus tarifas por litro son:
    •	Normal: $17.20
    •	Súper: $18.85
    •	Premium: $21.30 
    Desarrollar una aplicación Orientada a Objetos utilizando VB.Net o C# que permita:
    1)	Obtener la recaudación total de la estación de servicio.
    2)	Obtener la recaudación total de un surtidor.
    3)	Obtener el surtidor que más recaudó.
    4)	Obtener el surtidor que menos recaudó.
    5)	Obtener el surtidor que más clientes tuvo.
    6)	Calcular el porcentaje de venta de cada tipo de nafta.
    7)	Calcular el porcentaje de recaudación de cada tipo de nafta.
    8)	Recargar el surtidor cuando éste haya quedado vacío.
    9)	Mostrar el surtidor con mayor cantidad recargas.
    10)	Calcular el promedio de ventas por surtidor.
    11)	Calcular el promedio de recaudación por surtidor. */

    public partial class Index : Form
    {
        public Estacion estacion;

        public Surtidor surtidorElegido;

        public Index()
        {
            InitializeComponent();
            estacion = new Estacion();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            CargarSurtidores();
            CargarSurtidor();
            ActualizarRecaudacion();
        }

        private void CargarSurtidores()
        {
            Surtidores_comboBox.DataSource = null;
            Surtidores_comboBox.DataSource = estacion.Surtidores;
        }

        private void CargarSurtidor()
        {
            if (surtidorElegido != null)
            {
                tipoNafta_lbl.Text = surtidorElegido.Nafta.Tipo.ToString();
                precio_lbl.Text = string.Format("${0:0.00}", surtidorElegido.Nafta.Precio);
                cantidad_lbl.Text = string.Format("{0:0.00} Lts", surtidorElegido.Cantidad);
            }
        }

        private void ActualizarRecaudacion()
        {
            recaudacion_lbl.Text = string.Format("${0:0.00}", estacion.Recaudacion);
        }

        private void Surtidores_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            surtidorElegido = Surtidores_comboBox.SelectedItem as Surtidor;
            CargarSurtidor();
            ActualizarLimiteCargar();
        }

        private void ActualizarLimiteCargar()
        {
            Cantidad_numericUpDown.Maximum = Convert.ToDecimal(surtidorElegido.Cantidad); 
        }

        private void Recargar_btn_Click(object sender, EventArgs e)
        {
            if (surtidorElegido != null)
            {
                if (surtidorElegido.Cantidad != 1000) surtidorElegido.Recargar();
                else MessageBox.Show("Surtidor Lleno.");
                CargarSurtidor();
            } else
            {
                MessageBox.Show("Seleccioná un surtidor para poder recargar.");
            }
        }

        private void Cargar_btn_Click(object sender, EventArgs e)
        {
            if (Cantidad_numericUpDown.Value > 0)
            {
                if (surtidorElegido != null)
                {
                    int resultado = estacion.Vender(surtidorElegido, (float)Cantidad_numericUpDown.Value);
                    if (resultado == 0) MessageBox.Show("¡Venta realizada con éxito!");
                    else MessageBox.Show("No se ha podido realizar la venta.");
                    CargarSurtidor();
                    ActualizarRecaudacion();
                    Cantidad_numericUpDown.Value = 0;
                }
                else MessageBox.Show("Seleccioná un surtidor para continuar.");
            }
            else MessageBox.Show("El monto de carga debe ser superior a 0 para continuar.");
        }
    }
}
