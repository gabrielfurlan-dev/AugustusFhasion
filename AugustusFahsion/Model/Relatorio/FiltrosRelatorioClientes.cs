using AugustusFahsion.Enum;
using AugustusFahsion.Model.ValueObjects;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace AugustusFahsion.Model.Relatorio
{
    class FiltrosRelatorioClientes
    {
        public string NomeCliente { get; set; }
        public OrdemRelatorioDeVenda OrdenarPor { get; set; }
        public string DirecaoOrdem { get; set; }
        public decimal TotalLiquidoInicial{ get; set; }
        public int QuantidadeDeClientes { get; set; }
        public DateTime DataInicial{ get; set; }
        public DateTime DataFinal{ get; set; }

        public string GerarFiltrosSelect() 
        {
            var select = @"SELECT ";

            if (QuantidadeDeClientes != 0)
                select = @"SELECT TOP " + QuantidadeDeClientes;

            return select;
        }
        public string GerarFiltrosHaving()
        {
            var having = @" ";

            if (TotalLiquidoInicial != 0)
                having += @" HAVING sum(v.TotalLiquido) > @TotalLiquidoInicial ";

            return having;
        }

        public static string GetEnumDescription(OrdemRelatorioDeVenda value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

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

        internal string GerarFiltrosOrderBy() => GetEnumDescription(OrdenarPor);

        internal string GerarDirecaoDaOrdem() 
        {
            var direcao = @" ";
            if (DirecaoOrdem == "Decrescente")
                direcao = " DESC ";

            return direcao;
        }

        
    }
}
