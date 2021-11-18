using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class Metodos
    {
        public static string RemoverMascaraDeFormatacao(string valor)
        {
            string valorSemFormatacao = valor;

            valorSemFormatacao = new string((from c in valorSemFormatacao
                                             where char.IsDigit(c)
                                             select c).ToArray());

            return valorSemFormatacao;
        }
    }

    public static class Validacoes
    {
        public static bool NuloOuVazio(string texto) =>
        !string.IsNullOrEmpty(texto);

        public static bool EhNumerico(this string valor) =>
            int.TryParse(valor, out _);
    }

    public static class Extensoes
    {
        public static bool EstaSelecionado(this ComboBox comboBox) =>
           comboBox.SelectedIndex > 0;
        public static bool NuloOuVazio(this string texto) =>
            string.IsNullOrEmpty(texto);
        public static bool DataDeHoje(this DateTime dataNascimento) =>
            dataNascimento == DateTime.Now;

        public static int IntOuZero(this string valor)
        {
            int.TryParse(valor, out int resultado);
            return resultado;
        }

        public static decimal RealParaDecimal(this string valor) =>
            decimal.Parse(valor, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
    }
}
