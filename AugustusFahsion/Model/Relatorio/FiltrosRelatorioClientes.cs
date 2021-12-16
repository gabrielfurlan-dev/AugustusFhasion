using AugustusFahsion.Enums;
using AugustusFahsion.Model.ValueObjects;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace AugustusFahsion.Model.Relatorio
{
    public class FiltrosRelatorioClientes
    {
        public string NomeCliente { get; set; }
        public EFiltroRelatorioDeVenda FiltrarPor { get; set; }
        public EOrdemRelatorioDeVenda OrdenarPor { get; set; }
        public string DirecaoOrdem { get; set; }
        public decimal APartirDe{ get; set; }
        public int QuantidadeDeClientes { get; set; }
        public DateTime DataInicial{ get; set; }
        public DateTime DataFinal{ get; set; }

        public string GerarFiltrosSelect() 
        {

            if (QuantidadeDeClientes != 0)
                return @"SELECT TOP " + QuantidadeDeClientes;

            return @"SELECT ";
        }
        public string GerarFiltrosHaving()
        {
            var having = @" ";

            if (APartirDe != 0)
                having += $" HAVING {GetEnumDescription(FiltrarPor)} > @APartirDe ";

            return having;
        }
        internal string GerarFiltrosOrderBy()
        {
            var a = GetEnumDescription(OrdenarPor);
            return a;
        }
        internal string GerarDirecaoDaOrdem()
        {
            var direcao = @" ";
            if (DirecaoOrdem == "Decrescente")
                direcao = " DESC ";

            return direcao;
        }

        public static string GetEnumDescription<T> (T value) where T : Enum
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            //metodo para pegar o enum description
            try
            {
                DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attributes != null && attributes.Any())
                {
                    return attributes.First().Description;
                }

                return value.ToString();
            }
            catch (Exception)
            {
                return " ";
            }
        }

    }
}
