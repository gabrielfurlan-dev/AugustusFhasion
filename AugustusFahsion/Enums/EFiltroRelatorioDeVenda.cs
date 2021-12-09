using System.ComponentModel;

namespace AugustusFahsion.Enums
{
    public enum EFiltroRelatorioDeVenda
    {
        [Description(" sum(v.TotalLiquido) ")]
        Nome = -1,
        [Description(" count(v.IdVenda) ")]
        Quantidade,
        [Description(" sum(v.TotalDesconto) ")]
        TotalDesconto,
        [Description(" sum(v.TotalLiquido) ")]
        TotalLiquido
    }
}
