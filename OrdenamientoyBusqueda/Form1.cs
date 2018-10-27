using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdenamientoyBusqueda
{
    public partial class Form1 : Form
    {
        int[] v;
        Random random = new Random();
        byte[] buffer = new byte[10];

        public Form1()
        {
            InitializeComponent();
  
            v = new int[10];
            random.NextBytes(buffer);
            for (int i=0; i<10; i++)
            {
                v[i] = (int)buffer[i];
            }
            lbNumeros.Text = Imprimir(v);

        }

        
        public static string Imprimir(int[] v)
        {
            string numeros="";
            for (int i = 0; i < v.Length; i++)
            {
                numeros = numeros + "       " + v[i];
            }
            return numeros;
        }

        private void btnNuevos_Click(object sender, EventArgs e)
        {
            random.NextBytes(buffer);
            for (int i = 0; i < 10; i++)
            {
                v[i] = (int)buffer[i];
            }
            lbNumeros.Text = Imprimir(v);
        }


        public static int Binario(int[] V, int buscar)
        {
            int izq = 0;
            int der = V.Length;
            int centro = (izq + der) / 2;
            bool encontrado = false;
            while (izq <= der &&! encontrado)
            {
                if (V[centro] == buscar)
                {
                    encontrado = true;
                }
                else
                {
                    if (buscar > V[centro])
                    {
                        izq = centro + 1;
                    }
                    else
                    {
                        der = centro - 1;
                    }
                }
                centro = (der + izq) / 2;
            }
            if (encontrado)
            {
                return centro;
            }
            else
            {
                return -1;
            }

        }

        static void Burbuja(int[] V)
        {
            int aux = 0;
            for (int i = 0; i < V.Length; i++)
            {
                for (int j = 0; j < V.Length - 1; j++)
                {
                    if (V[j] > V[j + 1])
                    {
                        aux = V[j];
                        V[j] = V[j + 1];
                        V[j + 1] = aux;
                    }
                }
            }
        }

        static void QuickSort(int[] V, int primero, int ultimo)
        {
            int i; //contadores
            int j; //contadores
            int centro; //centro del vector
            int pivote; //Elemento a comparar con el arreglo
            int aux; //Auxiliar para realiar el intercambio de valores
            i = primero;
            j = ultimo;
            centro = (primero + ultimo) / 2;
            pivote = V[centro];

            do
            {
                while (V[i] < pivote) i++;
                while (V[j] > pivote) j--;
                if (i <= j)
                {
                    aux = V[i];
                    V[i] = V[j];
                    V[j] = aux;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > primero)
            {
                QuickSort(V, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(V, i, ultimo);
            }
        }

        static int Secuencial (int [] V, int buscar)
        {
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] == buscar)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            lbPos.Visible = true;
            try
            {
                int indice = int.Parse(txtbBuscar.Text);
                indice = Binario(v, int.Parse(txtbBuscar.Text));
                if (indice != -1)
                {
                    lbEncontrado.Text = "¡Encontrado!";
                    lbPos.Text = "Ubicacion: " + indice.ToString();
                }
                else
                {
                    lbEncontrado.Text = "No encontrado.";
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtbBuscar, "No ha introducido un valor");
            }
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Burbuja(v);
            lbOrden.Text = Imprimir(v);
        }

        private void bntQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort(v, 0, v.Length - 1);
            lbOrden.Text = Imprimir(v);
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            lbPos.Visible = true;
            try
            {
                int indice = int.Parse(txtbBuscar.Text);
                indice = Secuencial(v, int.Parse(txtbBuscar.Text));
                if (indice != -1)
                {
                    lbEncontrado.Text = "¡Encontrado!";
                    lbPos.Text = "Ubicacion: " + indice.ToString();
                }
                else
                {
                    lbEncontrado.Text = "No encontrado.";
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtbBuscar, "No ha introducido un valor");
            }
        }
    }
}
