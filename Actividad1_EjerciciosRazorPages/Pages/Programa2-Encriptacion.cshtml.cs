using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Actividad1_EjerciciosRazorPages.Pages
{
    public class Programa2_EncriptacionModel : PageModel
    {
        [BindProperty]
        public string mensaje { get; set; }

        [BindProperty]
        public string accionMensaje { get; set; }

        [BindProperty]
        public string posiciones { get; set; }

        public string resultado { get; set; } = "";

        public void OnPost()
        {
            int posicionesInt = int.Parse(posiciones);

            if( accionMensaje.Equals("codificar") )
            {
                resultado = encriptarMensaje(mensaje, posicionesInt);
            }

            if(accionMensaje.Equals("decodificar"))
            {
                resultado = desencriptarMensaje(mensaje, posicionesInt);
            }
        }

        private string encriptarMensaje( string mensaje, int posiciones )
        {
            string result = "";

            foreach (char c in mensaje.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    switch (c)
                    {
                        case 'A':
                            //Este proceso lo que hace es convertir la letra en ASCII ( (int)A )
                            //Le suma la cantidad de posiciones a aumentar ( + posiciones )
                            //Ahora le restamos el numero ASCII que le corresponde a la A ( - (int)'A' )
                            //Obtenemos el modulo de 26 porque el abecedario solo tiene 26 letras ( % 26 )
                            //Y al resultado le sumamos el valor ASCII de la primera letra del abecedario ( + (int)'A' )
                            result += (char)(((int)'A' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'B':
                            result += (char)(((int)'B' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'C':
                            result += (char)(((int)'C' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'D':
                            result += (char)(((int)'D' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'E':
                            result += (char)(((int)'E' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'F':
                            result += (char)(((int)'F' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'G':
                            result += (char)(((int)'G' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'H':
                            result += (char)(((int)'H' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'I':
                            result += (char)(((int)'I' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'J':
                            result += (char)(((int)'J' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'K':
                            result += (char)(((int)'K' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'L':
                            result += (char)(((int)'L' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'M':
                            result += (char)(((int)'M' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'N':
                            result += (char)(((int)'N' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'O':
                            result += (char)(((int)'O' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'P':
                            result += (char)(((int)'P' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Q':
                            result += (char)(((int)'Q' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'R':
                            result += (char)(((int)'R' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'S':
                            result += (char)(((int)'S' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'T':
                            result += (char)(((int)'T' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'U':
                            result += (char)(((int)'U' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'V':
                            result += (char)(((int)'V' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'W':
                            result += (char)(((int)'W' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'X':
                            result += (char)(((int)'X' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Y':
                            result += (char)(((int)'Y' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Z':
                            result += (char)(((int)'Z' + posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        default:
                            result += c;
                            break;
                    }
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private string desencriptarMensaje(string mensaje, int posiciones)
        {
            string result = "";

            foreach (char c in mensaje.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    switch (c)
                    {
                        case 'A':
                            //Este proceso es la inversa del anterior
                            //Convertimos la letra en ASCII ( (int)'A' )
                            //Le sumamos 26 ( + 26 )
                            //Ahora le restamos la posicion que introducimos en el formulario ( - posiciones )
                            //Le restamos la pimera letra del abecedario en ascci ( - (int)'A' )
                            //Sacamos el modulo nuevamente de 26 porque el abdecedario tiene 26 letras
                            //Y le sumamos la primera letra del abecedario
                            result += (char)(((int)'A' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'B':
                            result += (char)(((int)'B' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'C':
                            result += (char)(((int)'C' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'D':
                            result += (char)(((int)'D' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'E':
                            result += (char)(((int)'E' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'F':
                            result += (char)(((int)'F' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'G':
                            result += (char)(((int)'G' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'H':
                            result += (char)(((int)'H' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'I':
                            result += (char)(((int)'I' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'J':
                            result += (char)(((int)'J' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'K':
                            result += (char)(((int)'K' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'L':
                            result += (char)(((int)'L' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'M':
                            result += (char)(((int)'M' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'N':
                            result += (char)(((int)'N' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'O':
                            result += (char)(((int)'O' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'P':
                            result += (char)(((int)'P' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Q':
                            result += (char)(((int)'Q' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'R':
                            result += (char)(((int)'R' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'S':
                            result += (char)(((int)'S' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'T':
                            result += (char)(((int)'T' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'U':
                            result += (char)(((int)'U' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'V':
                            result += (char)(((int)'V' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'W':
                            result += (char)(((int)'W' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'X':
                            result += (char)(((int)'X' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Y':
                            result += (char)(((int)'Y' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        case 'Z':
                            result += (char)(((int)'Z' + 26 - posiciones - (int)'A') % 26 + (int)'A');
                            break;
                        default:
                            result += c;
                            break;
                    }
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

    }
}
