using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Surtidor
    {
		private Nafta nafta;
		public Nafta Nafta
		{
			get { return nafta; }
			set { nafta = value; }
		}

		private float recaudacion;
		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}

		private float cantidad = 1000;
		public float Cantidad
		{
			get { return cantidad; }
		}

		public Surtidor(Nafta nafta)
		{
			this.nafta = nafta;
		}

		public void Recargar()
		{
			cantidad = 1000;
		}

		public void Extraer(float cantidad)
		{
			if (this.cantidad >= cantidad) this.cantidad -= cantidad;
        }
	}
}
