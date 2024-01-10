using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Surtidor
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

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

		private int ventas = 0;
		public int Ventas
		{
			get { return ventas; }
			set { ventas = value; }
		}

		private int recargas = 0;
		public int Recargas
		{
			get { return recargas; }
			set { recargas = value; }
		}

		public Surtidor(int id, Nafta nafta)
		{
			this.id = id;
			this.nafta = nafta;
		}

		public void Recargar()
		{
			cantidad = 1000;
			recargas++;
		}

		public void Extraer(float cantidad)
		{
			if (this.cantidad >= cantidad) this.cantidad -= cantidad;
        }

        public override string ToString()
        {
			return $"Surtidor {this.id}";
        }
    }
}
