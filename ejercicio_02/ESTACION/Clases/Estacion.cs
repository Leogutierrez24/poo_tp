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

            naftas.ForEach(nafta => surtidores.Add(new Surtidor(surtidores.Count + 1, nafta)));
        }

        public int Vender(Surtidor surtidor, float cantidad)
        {
            int resultado = 0;
            if (surtidor.Cantidad >= cantidad)
            {
                Venta nuevaVenta = new Venta(surtidor, cantidad * surtidor.Nafta.Precio, cantidad);
                surtidor.Extraer(cantidad);
                ventas.Add(nuevaVenta);
                recaudacion += nuevaVenta.Total;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        public Surtidor SurtidorMayorRecaudacion()
        {
            List<Surtidor> coleccion = new List<Surtidor>();
            surtidores.ForEach(surtidor => coleccion.Add(surtidor));
            return coleccion.OrderByDescending(surtidor => surtidor.Recaudacion).First();
        }

        public Surtidor SurtidorMenorRecaudacion()
        {
            List<Surtidor> coleccion = new List<Surtidor>();
            surtidores.ForEach(surtidor => coleccion.Add(surtidor));
            return coleccion.OrderBy(surtidor => surtidor.Recaudacion).First();
        }

        public Surtidor SurtidorMasClientes()
        {
            List<Surtidor> coleccion = new List<Surtidor>();
            surtidores.ForEach(surtidor => coleccion.Add(surtidor));
            return coleccion.OrderByDescending(surtidor => surtidor.Ventas).First();
        }

        public List<(TipoNafta, float)> PorcentajesVentas()
        {
            (TipoNafta, float) item;
            List<(TipoNafta, float)> resultado = new List<(TipoNafta, float)>(); 
            int cantVentas = ventas.Count;
            List<Venta> coleccion = new List<Venta>();

            surtidores.ForEach(surtidor =>
            {
                ventas.ForEach(venta =>
                {
                    if (venta.Surtidor.Nafta.Tipo == surtidor.Nafta.Tipo) coleccion.Add(venta);
                });
                float porcentaje = coleccion.Count * 100 / cantVentas;
                item = (surtidor.Nafta.Tipo, porcentaje);
                resultado.Add(item);
                coleccion.Clear();
            });

            return resultado;
        }

        public List<(TipoNafta, float)> PorcentajesRecaudacion()
        {
            (TipoNafta, float) item;
            List<(TipoNafta, float)> resultado = new List<(TipoNafta, float)>();
            List<Venta> coleccion = new List<Venta>();

            surtidores.ForEach(surtidor =>
            {
                ventas.ForEach(venta =>
                {
                    if (venta.Surtidor.Nafta.Tipo == surtidor.Nafta.Tipo) coleccion.Add(venta);
                });
                float porcentaje = coleccion.Sum(venta => venta.Total) * 100 / recaudacion;
                item = (surtidor.Nafta.Tipo, porcentaje);
                resultado.Add(item);
                coleccion.Clear();
            });

            return resultado;
        }

        public Surtidor SurtidorMasRecargas()
        {
            List<Surtidor> coleccion = new List<Surtidor>();
            surtidores.ForEach(surtidor => coleccion.Add(surtidor));
            return coleccion.OrderByDescending(surtidor => surtidor.Recargas).First();
        }
    }
}
