using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Libreria
    {
        private List<Venta> ventas = new List<Venta>();
        public List<Venta> Ventas
        {
            get { return ventas; }
        }

        private float recaudacion = 0;
        public float Recaudacion
        {
            get { return recaudacion; }
        }

        public Libreria() { }

        public void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
            recaudacion += venta.Total;
        }
    }
}
