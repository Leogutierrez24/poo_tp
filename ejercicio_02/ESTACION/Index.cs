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
    11)	Calcular el promedio de recaudación por surtidor. 
    
    *Nota -> Los puntos 10 y 11 no tienen sentido, ya que solo hay 3 surtidores y 3 tipos de naftas
             (c/surtidor tiene un tipo). Esto es repetir el punto 6 y 7. Si hubiesen más surtidores tendria
             sentido.
     */

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
            CargarReportes();
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
            SurtidorRecaudacion_lbl.Text = string.Format("${0:0.00}", surtidorElegido.Recaudacion);
            recaudacion_lbl.Text = string.Format("${0:0.00}", estacion.Recaudacion);
        }

        private void CargarReportes()
        {
            Reportes_comboBox.Items.Add("Surtidor con mayor recaudación");
            Reportes_comboBox.Items.Add("Surtidor con menor recaudación");
            Reportes_comboBox.Items.Add("Surtidor con más clientes");
            Reportes_comboBox.Items.Add("Porcentaje de ventas");
            Reportes_comboBox.Items.Add("Porcentaje de recaudación");
            Reportes_comboBox.Items.Add("Surtidor con más recargas");
        }

        private void Surtidores_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            surtidorElegido = Surtidores_comboBox.SelectedItem as Surtidor;
            CargarSurtidor();
            ActualizarLimiteCargar();
            ActualizarRecaudacion();
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

        private void VerReporte_btn_Click(object sender, EventArgs e)
        {
            int index = Reportes_comboBox.SelectedIndex;
            if (index != -1)
            {
                string resultado;
                Reporte_listBox.Items.Clear();
                if (index == 0)
                {
                    Surtidor surtidor = estacion.SurtidorMayorRecaudacion();
                    resultado = string.Format("{0} con {1} con un total de ${2:0.00}", surtidor, surtidor.Nafta.Tipo, surtidor.Recaudacion);
                    Reporte_listBox.Items.Add(resultado);
                } else if (index == 1)
                {
                    Surtidor surtidor = estacion.SurtidorMenorRecaudacion();
                    resultado = string.Format("{0} con {1} con un total de ${2:0.00}", surtidor, surtidor.Nafta.Tipo, surtidor.Recaudacion);
                    Reporte_listBox.Items.Add(resultado);
                } else if (index == 2)
                {
                    Surtidor surtidor = estacion.SurtidorMasClientes();
                    resultado = $"{surtidor} con {surtidor.Nafta.Tipo} con una cantidad de {surtidor.Ventas} clientes";
                    Reporte_listBox.Items.Add(resultado);
                } else if (index == 3)
                {
                    List<(TipoNafta, float)> coleccion = estacion.PorcentajesVentas();
                    foreach((TipoNafta, float) item in coleccion)
                    {
                        Reporte_listBox.Items.Add(item);
                    }
                } else if (index == 4)
                {
                    List<(TipoNafta, float)> coleccion = estacion.PorcentajesRecaudacion();
                    foreach ((TipoNafta, float) item in coleccion)
                    {
                        Reporte_listBox.Items.Add(item);
                    }
                } else if (index == 5)
                {
                    Surtidor surtidor = estacion.SurtidorMasRecargas();
                    resultado = $"{surtidor} con {surtidor.Nafta.Tipo} con {surtidor.Recargas} recargas";
                    Reporte_listBox.Items.Add(resultado);
                }
            }
            else MessageBox.Show("Elegí una opción para continuar!!!");
        }
    }
}
