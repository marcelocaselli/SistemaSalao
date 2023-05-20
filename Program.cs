using CadastroSalao.Repository;
using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

const string connectionString = "Server=localhost, 1433;Database=CadastroSalao;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
// metodo buscar varios clientes

var connection = new SqlConnection(connectionString);
connection.Open();
//CreateClienteRepositorio(connection);
//CreateFuncionarioRepositorio(connection);
ReadClientesRepositorio(connection);
//ReadClienteRepositorio(connection);
//ReadFuncionariosRepositorio(connection);
//ReadFuncionarioRepositorio(connection);
//UpdateClienteRepositorio(connection);
//UpdateFuncionarioRepositorio(connection);
//DeleteClienteRepositorio(connection);
//DeleteFuncionarioRepositorio(connection);

connection.Close();


void ReadClientesRepositorio(SqlConnection connection)
{
    var repositorio = new ClienteRepositorio(connection);
    var clientes = repositorio.GetAll();
    foreach (var cliente in clientes)
    {
        Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Email} - {cliente.Telefone} - {cliente.Rua} - {cliente.Numero} - {cliente.Bairro}");
    }
}

void ReadClienteRepositorio(SqlConnection connection)
{
    var repositorio = new ClienteRepositorio(connection);
    var cliente = repositorio.Get(1);
    {
        Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Email} - {cliente.Telefone} - {cliente.Rua} - {cliente.Numero} - {cliente.Bairro}");
    }
}

void ReadFuncionariosRepositorio(SqlConnection connection)
{
    var repositorio = new FuncionarioRepositorio(connection);
    var funcionarios = repositorio.GetAll();
    foreach (var funcionario in funcionarios)
    {
        Console.WriteLine($"{funcionario.Id} - {funcionario.Nome} - {funcionario.Email} - {funcionario.Telefone} - {funcionario.Rua} - {funcionario.Numero} - {funcionario.Bairro}");
    }

}

void ReadFuncionarioRepositorio(SqlConnection connection)
{
    var repositorio = new FuncionarioRepositorio(connection);
    var funcionario = repositorio.Get(1);
    {
        Console.WriteLine($"{funcionario.Id} - {funcionario.Nome} - {funcionario.Email} - {funcionario.Telefone} - {funcionario.Rua} - {funcionario.Numero} - {funcionario.Bairro}");
    }
}

void CreateClienteRepositorio(SqlConnection connection)
{
    var repositorio = new ClienteRepositorio(connection);
    //var cliente = repositorio.Insert(clientes);
    var clientes = new Cliente()
    {
        Nome = "Rodrigo",
        Email = "rodrigo@gmail.com",
        Telefone = "16542576545",
        Rua = "Quedas e Iberia",
        Numero = 529,
        Bairro = "Parada Inglesa"
    };

    repositorio.CreateCliente(clientes);
}

void CreateFuncionarioRepositorio(SqlConnection connection)
{
    var repositorio = new FuncionarioRepositorio(connection);
    //var cliente = repositorio.Insert(clientes);
    var funcionarios = new Funcionario()
    {
        Nome = "Amanda",
        Email = "amanda@gmail.com",
        Telefone = "56439870912",
        Rua = "Do Alto",
        Numero = 54,
        Bairro = "Tremembe"
    };

    repositorio.CreateFuncionario(funcionarios);
}

void UpdateClienteRepositorio(SqlConnection connection)
{
    var repositorio = new ClienteRepositorio(connection);
    var cliente = new Cliente()
    {
        Id = 7,
        Nome = "Rodrigo Caselli",
        Email = "rodrigo@gmail.com",
        Telefone = "16542576545",
        Rua = "Quedas e Iberia",
        Numero = 529,
        Bairro = "Vila Isolina Mazzei"
    };
    repositorio.UpdateCliente(cliente);
}

void UpdateFuncionarioRepositorio(SqlConnection connection)
{
    var repositorio = new FuncionarioRepositorio(connection);
    var funcionario = new Funcionario()
    {
        Id = 1,
        Nome = "Lucia Helena Costa",
        Email = "lucia@gmail.com",
        Telefone = "09876543212",
        Rua = "Quedas e Iberia",
        Numero = 529,
        Bairro = "Isolina Mazzei"
    };
    repositorio.UpdateFuncionario(funcionario);
}

void DeleteClienteRepositorio(SqlConnection connection)
{
    var excluicliente = new ClienteRepositorio(connection);
    excluicliente.DeleteCliente(1);
}

void DeleteFuncionarioRepositorio(SqlConnection connection)
{
    var funcionario = new FuncionarioRepositorio(connection);
    funcionario.DeleteFuncionario(1);
}







