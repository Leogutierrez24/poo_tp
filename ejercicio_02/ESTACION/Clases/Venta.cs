﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Venta
    {
		private Surtidor surtidor;
		public Surtidor Surtidor
		{
			get { return surtidor; }
			set { surtidor = value; }
		}

		private float total;
		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		private float cantidad;
		public float Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		public Venta(Surtidor surtidor, float total, float cantidad)
		{
			this.surtidor = surtidor;
			this.total = total;
			this.cantidad = cantidad;
			this.Impactar();
		}

		private void Impactar()
		{
			surtidor.Recaudacion += total;
			surtidor.Nafta.Recaudacion += total;
			surtidor.Ventas++;
		}
	}
}
