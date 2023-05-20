
using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace CadastroSalao.Repository
{
    public class ClienteRepositorio
    {
        private readonly SqlConnection _connection;

        public ClienteRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _connection.GetAll<Cliente>();
        }

        public Cliente Get(int id)
        {
            return _connection.Get<Cliente>(id);
        }

        public void CreateCliente(Cliente cliente)
        {
            cliente.Id = 0;
            _connection.Insert<Cliente>(cliente);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public void UpdateCliente(Cliente cliente)
        {
            if (cliente.Id != 0)
                _connection.Update<Cliente>(cliente);
            Console.WriteLine("Cadastro atualizado com sucesso");
        }

        public void DeleteCliente(Cliente cliente)
        {
            if (cliente.Id != 0)
            {
                _connection.Delete<Cliente>(cliente);
            }
            Console.WriteLine("Registro excluído com sucesso");
        }

        public void DeleteCliente(int id)
        {
            var cliente = _connection.Get<Cliente>(id);
            _connection.Delete<Cliente>(cliente);
            Console.WriteLine("Registro excluído com sucesso");
        }
    }
}



