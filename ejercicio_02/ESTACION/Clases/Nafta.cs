using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Nafta
    {
		private TipoNafta tipo;
		public TipoNafta Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private float precio;
		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private float recaudacion = 0;
		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}

		public Nafta(TipoNafta tipo, float precio)
		{
			this.tipo = tipo;
			this.precio = precio;
		}

	}
}
