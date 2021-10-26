using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class Validar
    {
        public bool NuloOuVazio(string texto, string mensagem)
        {
            if (!String.IsNullOrEmpty(texto)) {
                MessageBox.Show(mensagem);
                return false;
            }
            else
                return true;
        }
        public bool DataDeHoje (DateTime dataNascimento, string mensagem)
        {
            if (dataNascimento == DateTime.Now)
            {
                MessageBox.Show(mensagem);
                return true;
            }
            else
                return false;
        }
        public bool MenorQueZeroDouble(double valor, string mensagem)
        {
            if (valor < 0) { 
                MessageBox.Show(mensagem);
                return true;
            }
            else
                return false;
        }
        public bool MenorQueZeroInt(double valor, string mensagem)
        {
            if (valor < 0)
            {
                MessageBox.Show(mensagem);
                return true;
            }
            else
                return false;
        }
    }
}
