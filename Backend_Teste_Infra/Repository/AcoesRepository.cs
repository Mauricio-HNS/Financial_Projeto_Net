using Backend_Teste_Domain.Interfaces;
using Backend_Teste_Domain.Models;
using System.Data;
using System.Data.SqlClient;

namespace Backend_Teste_Infra.Repository
{
    public class AcoesRepository : IAcoesRepository
    {
        private IDbConnection _connection;

        public AcoesRepository(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;",);
                // Do work here; connection closed on following line.
            }
        }

        public bool VerificarSeAcaoExiste(int idAcao)
        {
            var query = "SELECT Codigo_acao FROM Acoes WHERE Codigo_acao = @codigo";

            var acao = _connection.QueryFirstOrDefault<int>(query, new
            {
                codigo = idAcao
            });

            if (acao == 0)
            {
                return false;
            }

            return true;

        }

        public void CadastrarAcao(NovaAcao acao)
        {
            var query = "INSERT INTO Acoes (Codigo_acao, Razao_social_empresa) VALUES (@codigo, @empresa)";

            _connection.ExecuteAsync(query, new
            {
                codigo = acao.IdAcao,
                empresa = acao.RazaoSocialEmpresa
            });

        }

        public void CompraAcao(ComprarAcaoCompleta acao)
        {
            var query = "INSERT INTO Compra_acoes (Codigo_acao, Preco, Quantidade, DataCompra, ValorTotal) VALUES (@codigo, @preco, @quantidade, @data, @total)";

            _connection.ExecuteAsync(query, new
            {
                codigo = acao.IdAcao,
                preco = acao.Preco,
                quantidade = acao.Quantidade,
                data = acao.DataCompra,
                total = acao.ValorTotal
            });
        }

        public void VendaAcao(VendaAcaoCompleta acao)
        {
            var query = "INSERT INTO Venda_acoes (Codigo_acao, Preco, Quantidade, DataVenda, ValorTotal) VALUES (@codigo, @preco, @quantidade, @data, @total)";

            _connection.ExecuteAsync(query, (
                codigo: acao.IdAcao,
                preco: acao.Preco,
                quantidade: acao.Quantidade,
                data: acao.DataVenda,
                total: acao.ValorTotal
            ));
        }
    }
}
