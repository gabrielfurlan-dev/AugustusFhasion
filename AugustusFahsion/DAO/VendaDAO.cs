using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;

namespace AugustusFahsion.DAO
{
    class VendaDAO
    {
        //FUNÇÕES C R U D ===============================================================
        //CRIAR
        public static void RegistrarVenda(VendaModel vendaModel)
        {
            var venda = @"insert into Venda (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDesconto, 
		                        TotalLiquido)
                                output inserted.IdVenda
                                values ( @IdCliente, @IdColaborador, @FormaPagamento, 
                                @TotalBruto, @TotalDesconto, @TotalLiquido)";

            var VendaProduto = @"insert VendaProduto (IdProdutoGuid, IdProduto, IdVenda, PrecoVenda, Quantidade,
                                    PrecoLiquido, Desconto, Total) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @PrecoLiquido, @Desconto, @Total)";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open(); 
                using (var transacao = conexao.BeginTransaction())
                {
                    vendaModel.IdVenda = conexao.ExecuteScalar<int>(venda, vendaModel,transacao);

                    vendaModel.VendaProdutoModel.ForEach(x => x.IdVenda = vendaModel.IdVenda);

                    conexao.Execute(VendaProduto, vendaModel.VendaProdutoModel, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex) 
            { 
                 throw new Exception(ex.Message);
            }
        }

        public static List<VendaListagemModel> ListarVendas()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador
					from Venda v
                    inner join Cliente c on v.IdCliente = c.IdCliente
					inner join Colaborador co on v.IdColaborador = co.IdColaborador
					inner join Pessoa p on p.IdPessoa = c.IdPessoa 
					inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa";

                    return conexao.Query<VendaListagemModel>(query).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static VendaModel BuscarVenda(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where IdProduto=@id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<VendaModel>(query, parametros);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public static List<ClienteListagemModel> BuscarClientePorNome(string nome)
        //{
        //    const string listarPessoa = @"select c.IdPessoa, c.IdCliente, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa,
        //        e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
        //        cn.Telefone, cn.Celular, cn.Email
        //        from Pessoa p
        //        inner join Cliente c on p.IdPessoa = c.IdPessoa
        //        inner join Endereco e on p.IdPessoa = e.IdPessoa
        //        inner join Contato cn on p.IdPessoa = cn.IdPessoa
        //        where p.Nome like @nome + '%'";
        //    try
        //    {
        //        using (var conexao = new SqlConexao().Connection())
        //        {
        //            //return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
        //            //    (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
        //            //    new { nome }, splitOn: "IdPessoa").AsList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public static List<ClienteListagemModel> BuscarClientePorId(int id)
        //{
        //    const string listarPessoa = @"select c.IdPessoa, c.IdCliente. p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, e.Cep, 
        //        e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, cn.Telefone, cn.Celular, cn.Email,
        //        from Pessoa p
        //        inner join Cliente c on p.IdPessoa = c.IdPessoa
        //        inner join Endereco e on p.IdPessoa = e.IdPessoa
        //        inner join Contato cn on p.IdPessoa = cn.IdPessoa 
        //        where p.IdPessoa = @id";
        //    try
        //    {
        //        using (var conexao = new SqlConexao().Connection())
        //        {
        //            //return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
        //            //    (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
        //            //    new { id }, splitOn: "IdPessoa").AsList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
