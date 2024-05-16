using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Actividad1_EjerciciosRazorPages.Pages
{
    public class Programa4_AleatorioModel : PageModel
    {
        public int[] ArregloNumeros { get; set; }
        public int suma { get; set; } = 0;
        public double mediaAritmetica { get; set; } = 0.0;
        public double mediana { get; set; } = 0.0;
        public int moda { get; set; } = 0;

        public void OnGet()
        {
            Random random = new Random();

            ArregloNumeros = new int[20];
            for (int i = 0; i < ArregloNumeros.Length; i++)
            {
                ArregloNumeros[i] = random.Next(101);
                //Suma de los numeros
                suma += ArregloNumeros[i];
            }
            //Ordenamiendo por metodo de la burbuja
            metodoBurbuja(ArregloNumeros);
            //Calculo de la media aitmetica
            mediaAritmetica += (double)suma / ArregloNumeros.Length;
            //Calculo de la mediana
            if ( ArregloNumeros.Length % 2 == 0 )
            {
                double valorPosicion = ArregloNumeros.Length / 2;
                int num1 = ArregloNumeros[(int)valorPosicion - 1];
                int num2 = ArregloNumeros[(int)valorPosicion];

                mediana += (double)(num1 + num2) / 2;
            }
            else
            {
                double valorPosicion = ArregloNumeros.Length / 2;
                mediana = ArregloNumeros[(int)Math.Ceiling(valorPosicion)];
            }

            moda = CalcularModa(ArregloNumeros);
        }

        void metodoBurbuja(int[] arregloNumeros)
        {
            int i, j;
            for (i = 0; i < arregloNumeros.Length - 1; i++)
            {
                for (j = 0; j < arregloNumeros.Length - i - 1; j++)
                {
                    if (arregloNumeros[j] > arregloNumeros[j + 1])
                    {
                        int temp = arregloNumeros[j];
                        arregloNumeros[j] = arregloNumeros[j + 1];
                        arregloNumeros[j + 1] = temp;
                    }
                }
            }
        }

        int CalcularModa(int[] arregloNumeros)
        {
            Dictionary<int, int> frecuencias = new Dictionary<int, int>();

            foreach (int num in arregloNumeros)
            {
                if (frecuencias.ContainsKey(num))
                    frecuencias[num]++;
                else
                    frecuencias[num] = 1;
            }

            int moda = 0;
            int maxFrecuencia = 0;

            foreach (var par in frecuencias)
            {
                if (par.Value > maxFrecuencia)
                {
                    moda = par.Key;
                    maxFrecuencia = par.Value;
                }
            }

            return moda;
        }
    }
}
