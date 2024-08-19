using Business;
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
        optionsBuilder.UseSqlServer("server=DESKTOP-O1S388N\\SQLEXPRESS;database=Cafeteria;trusted_Connection=true;encrypt=false");
        Context context = new Context(optionsBuilder.Options);
        CategoriaRepository repository = new CategoriaRepository(context);
        bool continua = true;
        while (continua)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções para Categorias\n" +
                              "1 - Cadastrar nova categoria \n" +
                              "2 - Recuperar categoria pelo Id\n" +
                              "3 - Recuperar todas as categorias\n" +
                              "4 - Remover Categoria pelo Id\n" +
                              "5 - alterar categoria pelo Id\n" +
                              "6 - voltar ao menu principal");
            var opc = Console.ReadLine();
            if (opc.ToString().Equals("1"))
            {
                Console.WriteLine("Informe o nome da categoria");
                var nome = Console.ReadLine();
                Console.WriteLine("informe a imagem");
                var imagem = Console.ReadLine();

                Categoria categoria = new Categoria();
                categoria.Nome = nome.ToString();
                categoria.Imagem = imagem.ToString();
                repository.Insert(categoria);
                repository.Persist();
                Console.WriteLine("Categoria cadastrada com sucesso!");
                Console.ReadLine();
            }else if (opc.ToString().Equals("2"))
            {
                Console.WriteLine("digite o id da categoria");
                var id = Console.ReadLine();
                int? id_convertido = Convert.ToInt32(id);
                Categoria categoria = repository.GetById(id_convertido.Value);
                Console.WriteLine("produto: "+categoria.Id+"\n"+categoria.Nome + "\n" + categoria.Imagem);
                Console.ReadLine();
            }
            else if (opc.ToString().Equals("3"))
            {
                Console.WriteLine("lista de categorias");
                List<Categoria> list = repository.GetAll();
                foreach(Categoria cat in list)
                {
                    Console.WriteLine("id: "+cat.Id.ToString()+"\n"+cat.Nome+"\n" + cat.Imagem);
                }
                Console.ReadLine();
            }
            else if (opc.ToString().Equals("4"))
            {
                Console.WriteLine("informe o id que será apagado");
                var id = Console.ReadLine();
                int? idConvertido = null;
                try
                {
                    idConvertido = Convert.ToInt32(id);
                }
                catch
                {
                    Console.WriteLine("digite um id valido");
                    Console.ReadLine();
                }
                if (idConvertido != null) {
                    Categoria categoria = repository.GetById(idConvertido.Value);
                    if (categoria != null)
                    {
                        repository.Delete(categoria);
                        repository.Persist();
                    }
                    else
                    {
                        Console.WriteLine("categoria inexistente");
                    }
                }

            }
            else if (opc.ToString().Equals("5"))
            {
                Console.WriteLine("informe o id que deseja alterar");
                var id = Console.ReadLine();
                int? idConvertido = null;
                try
                {
                    idConvertido = Convert.ToInt32(id);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("valor de id invalido");
                    Console.ReadLine();
                }

                if (idConvertido != null)
                {
                    Categoria categoria = repository.GetById(idConvertido.Value);
                    if (categoria != null)
                    {
                        Console.WriteLine("informe um nome");
                        var nome = Console.ReadLine();
                        Console.WriteLine("informe uma imagem");
                        var imagem = Console.ReadLine();

                        categoria.Nome = nome;
                        categoria.Imagem = imagem;
                        repository.Update(categoria);
                        repository.Persist();

                        Console.WriteLine("Categoria atualizada com sucesso");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("categoria não existente");
                        Console.ReadLine();
                    }
                }
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