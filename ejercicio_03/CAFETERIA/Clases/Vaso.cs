using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public abstract class Vaso
    {
		protected Cafe cafe;
		public Cafe Cafe
		{
			get { return cafe; }
		}

		protected float medida;
		public float Medida
		{
			get { return medida; }
		}

		public void Cargar(Cafe cafe)
		{
			this.cafe = cafe;
		}
	}
}
