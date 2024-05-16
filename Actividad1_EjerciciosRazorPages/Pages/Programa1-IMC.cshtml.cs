using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Actividad1_EjerciciosRazorPages.Pages
{
    public class Programa1_IMCModel : PageModel
    {
        public string rutaImg = "";
        public string mensaje = "";
        public double imc = 0;
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";

        public void OnPost()
        {
            double pesoFormateado = Convert.ToDouble(peso);
            double alturaFormateada = Convert.ToDouble(altura);

            imc += pesoFormateado / (alturaFormateada * alturaFormateada);

            if( imc < 18 )
            {
                mensaje += "Peso Bajo";
                rutaImg += "/images/pesoBajo.jfif";
            }
            if (imc >= 18 && imc < 25)
            {
                mensaje += "Peso Normal";
                rutaImg += "/images/pesoNormal.jfif";
            }
            if (imc >= 25 && imc < 27)
            {
                mensaje += "Sobre Peso";
                rutaImg += "/images/sobrePeso.jfif";
            }
            if (imc >= 27 && imc < 30)
            {
                mensaje += "Obesidad Grado I";
                rutaImg += "/images/sobrePeso.jfif";
            }
            if (imc >= 30 && imc < 40)
            {
                mensaje += "Obesidad Grado II";
                rutaImg += "/images/sobrePeso.jfif";
            }
            if ( imc >= 40 )
            {
                mensaje += "Obesidad Grado III";
                rutaImg += "/images/sobrePeso.jfif";
            }

            ModelState.Clear();
        }
    }
}
