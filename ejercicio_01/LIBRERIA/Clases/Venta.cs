using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Venta
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private List<Producto> productos = new List<Producto>();
        public List<Producto> Productos
        {
            get { return productos; }
        }

        private float total;
        public float Total
        {
            get { return total; }
        }

        public Venta(int id) 
        {
            this.id = id;
            this.total = 0;
        }

        public void AgregarProducto(Producto producto)
        {
            this.total += producto.Precio;
            productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            this.total -= producto.Precio;
            productos.Remove(producto);
        }

        public override string ToString()
        {
            return $"{this.id} - ${this.total}";
        }
    }
}
