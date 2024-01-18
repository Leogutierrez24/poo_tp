using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Venta
    {
		private Cafetera cafetera;
		public Cafetera Cafetera
		{
			get { return cafetera; }
			set { cafetera = value; }
		}

		private Vaso vaso;
		public Vaso Vaso
		{
			get { return vaso; }
			set { vaso = value; }
		}

		private float total;
		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		public Venta(Cafetera cafetera, Vaso vaso, float total)
		{
			this.cafetera = cafetera;
			this.vaso = vaso;	
			this.total = total;
		}
	}
}
