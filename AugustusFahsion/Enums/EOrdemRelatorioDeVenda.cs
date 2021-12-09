using System.ComponentModel;

namespace AugustusFahsion.Enums
{
    public enum EOrdemRelatorioDeVenda
    {
        [Description(" ")]
        Nome = -1,
        [Description(" ORDER BY QuantidadeVenda ")]
        Quantidade,
        [Description(" ORDER BY Desconto ")]
        TotalDesconto,
        [Description(" ORDER BY TotalLiquido")]
        TotalLiquido
    }
}
