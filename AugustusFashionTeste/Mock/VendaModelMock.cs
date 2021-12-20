using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;

namespace AugustusFashionTeste.Mock
{
    class VendaModelMock
    {
        public VendaModel RetornarVendaModel()
        {
            VendaModel vendaModel = new VendaModel()
            {
                IdVenda = 1,
                IdColaborador = 1,
                Cliente =
                {
                    IdCliente = 1,
                    IdPessoa = 1,
                    ValorLimiteAPrazo = 10,
                    Condicao = "Ativo",
                    ValorLimiteGasto = 5
                },
                FormaPagamento = "A prazo",
                Condicao = "Ativo",
                DataVenda = DateTime.Now,
                ListaDeItens = 
                {
                
                },
                Pago = false,
            };


            return vendaModel;
        }

        public VendaModel RetornarListaDeItens() 
        {
            var vendaModel = RetornarVendaModel();
            vendaModel.ListaDeItens.Add(new VendaProdutoModel()
            {
                IdProdutoGuid = Guid.NewGuid(),
                IdProduto = 1,
                Nome = "Pipa",
                Quantidade = 1,
                Desconto = 0,
                TotalLiquido = 10,
                PrecoVenda = 10,
                TotalBruto = 10,
                Lucro = 5
            });
            return vendaModel;
        }
    }
}
