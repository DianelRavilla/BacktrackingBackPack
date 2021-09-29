using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecMochila
{
    public class ELEMENTO
    {
        public int peso { set; get; }
        public int beneficio { set; get; }
        public string nombre { set; get; }

        public ELEMENTO(int peso, int beneficio, string nombre)
        {
            this.peso = peso;
            this.beneficio = beneficio;
            this.nombre = nombre;
        }
       
        public Boolean Igual (object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetHashCode() != obj.GetHashCode())
                return false;
            ELEMENTO other = (ELEMENTO)obj;
            if (this.peso != other.peso)
            { return false; }
            if (this.beneficio != other.beneficio)
            { return false; }
            return true;
        }
        public string toString()
        {
            return "Peso: " + peso + ", " + "Beneficio: " + beneficio;
        }
    }
}
