using Microsoft.EntityFrameworkCore;
using Repository.Entity_framework;
using Repository.Repositories;

public class Program
{
    static void Main(string[] args)
    {
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções: \n" +
                              "1 - Categorias\n" +
                              "2 - Alimentos\n" +
                              "3 - Contato\n" +
                              "4 - Estruturas\n" +
                              "5 - Usuarios\n" +
                              "6 - Variações\n" +
                              "7 - sair");
            var opc = Console.ReadLine();
            if (opc.ToString().Equals("1"))
            {
                menuCategoria();
            }
            else if (opc.ToString().Equals("2"))
            {

            }
            else if (opc.ToString().Equals("3"))
            {

            }
            else if (opc.ToString().Equals("4"))
            {

            }
            else if (opc.ToString().Equals("5"))
            {

            }
            else if (opc.ToString().Equals("6"))
            {

            }
            else if (opc.ToString().Equals("7"))
            {
                continua = false;
            }
            else
            {
                Console.WriteLine("opção não encontrada");
                Console.ReadLine();
            }
        }
    }
    static void menuCategoria()
    {
        DbContextOptionsBuilder<Context> optionsBuilder = new DbContextOptionsBuilder<Context>();
        optionsBuilder.UseSqlServer("server=endereço;datasbase=cafeteria;trusted_connection=true");
        CategoriaRepository repository = new CategoriaRepository();
        bool continua = true;
        while (continua)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções para Categorias\n" +
                              "1 - Cadastrar nova categoria \n" +
                              "2 - Recuperar categoria pelo Id\n" +
                              "3 - Recuperar todas as categorias" +
                              "4 - Remover Categoria pelo Id\n" +
                              "5 - alterar categoria pelo Id\n" +
                              "6 - voltar ao menu principal");
            var opc = Console.ReadLine();
            if (opc.ToString().Equals("1"))
            {

            }else if (opc.ToString().Equals("2"))
            {

            }
            else if (opc.ToString().Equals("3"))
            {

            }
            else if (opc.ToString().Equals("4"))
            {

            }
            else if (opc.ToString().Equals("5"))
            {

            }
            else if (opc.ToString().Equals("6"))
            {
                continua = false;  
            }
            else
            {
                Console.WriteLine("opção inexistente");
                Console.ReadLine();
            }
        }
    }
}