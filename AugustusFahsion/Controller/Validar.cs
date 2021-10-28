using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public static class Validar
    {
        public static bool NuloOuVazio(string texto) =>
        !string.IsNullOrEmpty(texto);
    }

    public static class Extensoes
    {
        public static bool EstaSelecionado(this ComboBox comboBox) =>
           comboBox.SelectedIndex > 0;

        public static bool NuloOuVazio(this string texto) =>
            string.IsNullOrEmpty(texto);

        public static bool DataDeHoje(this DateTime dataNascimento) =>
            dataNascimento == DateTime.Now;
    }
}
