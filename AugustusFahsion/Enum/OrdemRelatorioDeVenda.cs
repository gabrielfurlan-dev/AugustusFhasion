using System.ComponentModel;

namespace AugustusFahsion.Enum
{
    public enum OrdemRelatorioDeVenda
    {
        [Description (" ")]
        Nome = -1,
        [Description(" ORDER BY QuantidadeVenda ")]
        Quantidade,
        [Description(" ORDER BY Desconto ")]
        TotalDesconto,
        [Description(" ORDER BY TotalLiquido")]
        TotalLiquido
    }
}
