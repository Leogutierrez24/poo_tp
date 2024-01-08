using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Estacion
    {
        private List<Nafta> naftas = new List<Nafta>();
        public List<Nafta> Naftas
        {
            get { return naftas; }
            set { naftas = value; }
        }

        private List<Surtidor> surtidores = new List<Surtidor>();
        public List<Surtidor> Surtidores
        {
            get { return surtidores; }
            set { surtidores = value; }
        }

        private List<Venta> ventas = new List<Venta>();
        public List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

        private float recaudacion = 0;
        public float Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        public Estacion()
        {
            naftas = new List<Nafta> 
            {
                new Nafta(TipoNafta.Normal, 17.20f),
                new Nafta(TipoNafta.Super, 18.85f),
                new Nafta(TipoNafta.Premium, 21.30f),
            };

            naftas.ForEach(nafta => surtidores.Add(new Surtidor(nafta)));
        }

        public int Vender(Surtidor surtidor, float cantidad)
        {
            int resultado = 0;
            if (surtidor.Cantidad >= cantidad)
            {
                Venta nuevaVenta = new Venta(surtidor, cantidad * surtidor.Nafta.Precio, cantidad);
                surtidor.Extraer(cantidad);
                ventas.Add(nuevaVenta);
            } else
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
