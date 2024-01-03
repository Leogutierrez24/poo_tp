using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Producto
    {
        private string codigo;
        public string Codigo
        {
            get { return codigo; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
        }

        private float precio;
        public float Precio
        {
            get { return precio; } 
        }

        public Producto(string codigo, string nombre, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public override string ToString()
        {
            return $"{this.codigo} | {this.nombre} | ${this.precio}";
        }
    }
}
