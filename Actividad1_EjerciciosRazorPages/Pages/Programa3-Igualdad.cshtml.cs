using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Actividad1_EjerciciosRazorPages.Pages
{
    public class Programa3_IgualdadModel : PageModel
    {
        [BindProperty]
        public string valorA { get; set; } = "";
        [BindProperty]
        public string valorB { get; set; } = "";
        [BindProperty]
        public string valorX { get; set; } = "";
        [BindProperty]
        public string valorY { get; set; } = "";
        [BindProperty]
        public string valorN { get; set; } = "";
        public int resultadoIzquierda = 0;
        public List<int> resultadosDerecha;

        public void OnPost()
        {
            int valorAInt = int.Parse(valorA);
            int valorBInt = int.Parse(valorB);
            int valorXInt = int.Parse(valorX);
            int valorYInt = int.Parse(valorY);
            int valorNInt = int.Parse(valorN);

            resultadoIzquierda = calcularIzquierda(valorAInt, valorBInt, valorXInt, valorYInt, valorNInt);
            resultadosDerecha = calcularDerecha(valorAInt, valorBInt, valorXInt, valorYInt, valorNInt);
            
            //Console.WriteLine(calcularTermino(valorNInt, 0));
            //Console.WriteLine(calcularTermino(valorNInt, 1));
            //Console.WriteLine(calcularTermino(valorNInt, 2));
        }

        private int calcularIzquierda(int a, int b, int x, int y, int n)
        {
            int igualdadIzq = (int)Math.Pow( ( (a*x) + (b*y) ) , n);
            return igualdadIzq;
        }

        private List<int> calcularDerecha(int a, int b, int x, int y, int n)
        {
            List<int> resultados = new List<int>();
            int k = 0;
            for (k = 0; k <= n; k++)
            {
                resultados.Add( (int)calcularTermino(n, k) * (int)Math.Pow( a*x, n-k) * (int)Math.Pow( b*y , k ) );
            }
            return resultados;
        }

        private int calcularFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * calcularFactorial(num - 1);
            }
        }

        private int calcularTermino(int n, int k)
        {
            int valor = n - k;
            return calcularFactorial(n) / (calcularFactorial(k) * calcularFactorial(valor));
        }
    }
}
