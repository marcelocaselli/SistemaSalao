using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace CadastroSalao.Repository
{
    public class FuncionarioRepositorio
    {
        private readonly SqlConnection _connection;

        public FuncionarioRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return _connection.GetAll<Funcionario>();
        }

        public Funcionario Get(int id)
        {
            return _connection.Get<Funcionario>(id);
        }

        public void CreateFuncionario(Funcionario funcionario)
        {
            _connection.Insert<Funcionario>(funcionario);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            _connection.Update<Funcionario>(funcionario);
            Console.WriteLine("Cadastro atualizado com sucesso");
        }

        public void DeleteFuncionario(int id)
        {
            var funcionario = _connection.Get<Funcionario>(id);
            _connection.Delete<Funcionario>(funcionario);
            Console.WriteLine("Registro excluído com sucesso");
        }
    }
}