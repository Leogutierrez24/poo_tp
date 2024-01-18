using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Cafe
    {
		private TipoCafe tipo;
		public TipoCafe Tipo
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

		private int servido = 0;
		public int Servido
		{
			get { return servido; }
		}

		private float recaudacion = 0;
		public float Recaudacion
		{
			get { return recaudacion; }
		}

		public Cafe(TipoCafe tipo, float precio)
		{
			this.tipo = tipo;
			this.precio = precio;
		}

		//<summary>
		//Determina la cantidad
		//</summary>
		public void Servir(float total)
		{
			servido++;
			recaudacion += total;
		}
	}
}
