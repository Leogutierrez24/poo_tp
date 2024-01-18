using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Cafetera
    {
		private int id;
		public int Id
		{
			get { return id; }
		}

		private Cafe cafe;
		public Cafe Cafe
		{
			get { return cafe; }
			set { cafe = value; }
		}

		private float capacidad = 1f;
		public float Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		private float recaudacion;
		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}

		private int recargas = 0;
		public int Recargas
		{
			get { return recargas; }
		}

		private float descargas = 0f;
		public float Descargas
		{
			get { return descargas; }
		}

		public Cafetera(int id, Cafe cafe)
		{
			this.id = id;
			this.cafe = cafe;
		}

		public void Recargar()
		{
			capacidad = 1f;
			recargas++;
		}

		private int ComprobarCantidad(float cantidad)
		{
			int resultado = 0;
			if (cantidad > capacidad) resultado = -1;
			return resultado;
		}

		public void Descargar(float cantidad)
		{
			capacidad -= cantidad;
			descargas += cantidad;
		}

		public void ServirCafe(Vaso vaso)
		{
			if (ComprobarCantidad(vaso.Medida) == 0)
			{
                vaso.Cargar(this.cafe);
                Descargar(vaso.Medida);
            }
		}

	}
}
