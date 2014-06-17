using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClienteBancoDeDados
{
    class Program
    {
        private static SqlConnection sqlConection;
        static void Main(string[] args)
        {
            //INICIA CONEXÃO
            var sqlConection = ConectandoComBanco();

            Console.WriteLine("Tabela Dados do Cliente\n * Nome do Cliente\n * SobreNome do Cliente\n * Cidade do Cliente\n * Estado do Cliente\n * Cep do Cliente\n * Cpf do Cliente\n * Rg do Cliente ");
            Console.WriteLine("#####################################################");
            Console.WriteLine(" Escolha (1) Para Listar os Dados do Cliente no Banco\n Escolha (2) Adicionar os Dados do Cliente\n Escolha (3) Para alterar um Dado do Cliente\n Escolha (4) Para Excluir um dado do Cliente\n Escolha (5) Para Sair");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 5)
            {
                switch (opcao)
                {
                    case 1 : ListaTodosDados(sqlConection);
                        break;
                    default: Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            //FECHA CONEXÃO
            FechaConexao(sqlConection);
        }

         private static void ListaTodosDados(SqlConnection sqlConection)
        {
            //Listando todos o intens na tabela produto
            SqlCommand select = new SqlCommand("SELECT * FROM CLIENTE", sqlConection);
            SqlDataReader dataReader = select.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader["PRIMEIRO_NOME"]);
            }
            Console.ReadKey();
        }
        

        private static void FechaConexao(SqlConnection sqlConection)
        {
           //Fecha a conexão
           sqlConection.Close();
          }
        private static SqlConnection ConectandoComBanco()
        {
            //Define uma string de conexão com o banco de dados CursoNDD.mdf
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prijo\Source\Repos\RepositorioAprigio\RepositorioAprigio\Unidade12\BancoDeDados\APRIGIODB.mdf;Integrated Security=True";

            //Cria um novo objeto SqlConnection object usando a string de conexão
            SqlConnection sqlConn = new SqlConnection(connectionString);

            //Abre a conexão
            sqlConn.Open();
            return sqlConn;
        }
    }
}
