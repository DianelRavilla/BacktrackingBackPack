using System;
using System.Windows.Forms;

namespace ProyecMochila
{
    public class MOCHILA
    {
        public int pesoMaximo { set; get; }
        public ELEMENTO[] elementos { set; get; }

        public int peso { set; get; }
        public int beneficio { set; get; }

        public MOCHILA(int pesoMaximo, int numElementos)
        {
            this.pesoMaximo = pesoMaximo;
            elementos = new ELEMENTO[numElementos];
            beneficio = 0;
            peso = 0; 
        }

         // Añade un elemento a la mochila            
        public void Añadir(ELEMENTO e)
        {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == null)
                {
                    elementos[i] = e;                       //lo añade
                    beneficio = beneficio + e.beneficio;    // aumenta el beneficio
                    peso = peso + e.peso;                   // Aumenta el peso
                    break;
                }
            }
        }

        //Vaciando la mochila
        public void clear()
        {
            peso = 0;
            beneficio = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = null;
            }
        }
        
         //Elimina elemento dado      
        public void eliminarElemento(ELEMENTO e)
        {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i].Igual(e))
                {
                    elementos[i] = null;                    //el elemento fuera
                    peso= peso - e.peso;                    //Reduce el peso
                    beneficio = beneficio - e.beneficio;    // reduce el beneficio
                    break;
                }
            }
        }

        //Indica si existe un elemento 
        public bool existeElemento(ELEMENTO e)
        {
            for (int i = 0; i <elementos.Length; i++)
            {
                if (elementos[i] != null && elementos[i].Igual(e))
                {
                    return true;
                }
            }
            return false;
        }      

        public void MostrarElementos(ListBox L)
        {
            L.Items.Clear();
            L.Items.Add("Elementos en la mochila");
            for (int i = 0; i < elementos.Length; i++)
            {
                L.Items.Add(elementos[i].nombre);
            }
        }
    }


}