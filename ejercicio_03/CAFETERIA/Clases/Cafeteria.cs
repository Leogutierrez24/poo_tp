using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Cafeteria
    {
		private List<Cafe> cafes;
		public List<Cafe> Cafes
		{
			get { return cafes; }
			set { cafes = value; }
		}

		private List<Cafetera> cafeteras;
		public List<Cafetera> Cafeteras
		{
			get { return cafeteras; }
			set { cafeteras = value; }
		}

		private List<Venta> ventas;
		public List<Venta> Ventas
		{
			get { return ventas; }
			set { ventas = value; }
		}

		private float recaudacion = 0;
		public float Recaudacion
		{
			get { return recaudacion; }
		}

		public Cafeteria()
		{
			cafes = new List<Cafe>
			{
				new Cafe(TipoCafe.Arabigo, 50f),
				new Cafe(TipoCafe.Robusto, 58f),
			};

			cafeteras = new List<Cafetera>
			{
				new Cafetera(1, cafes[0]),
				new Cafetera(2, cafes[1]),
			};

			ventas = new List<Venta>();
		}

		private Vaso DeterminarVaso(TipoVaso tipo)
		{
			Vaso vaso;
			if (tipo == TipoVaso.Chico) vaso = new VasoChico();
			else if (tipo == TipoVaso.Mediano) vaso = new VasoMediano();
			else vaso = new VasoGrande();
			return vaso;
		}

		public int VenderCafe(Cafetera cafetera, TipoVaso tipoVaso)
		{
			int resultado = 0;
			Vaso vaso = DeterminarVaso(tipoVaso);
			cafetera.ServirCafe(vaso);

			if (vaso.Cafe != null)
			{
				float total = cafetera.Cafe.Precio * vaso.Medida;
				cafetera.Cafe.Servir()
                Venta nuevaVenta = new Venta(cafetera, vaso, total);
			}
			else resultado = -1;

			return resultado;
		}
	}
}
