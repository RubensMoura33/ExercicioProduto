namespace Projeto_Menu_Produto
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {

            Console.WriteLine($"---------------------------");
            Console.WriteLine($"Agora logue em sua conta");
            Console.WriteLine($"--------------------------");

            Console.WriteLine($"Insira seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login aceito !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Dados invalidos, tente novamente!");
                while (email != usuario.Email || senha != usuario.Senha)
                {
                    Console.WriteLine($"Insira seu email: ");
                    email = Console.ReadLine();

                    Console.WriteLine($"Insira sua senha: ");
                    senha = Console.ReadLine();

                    if (email == usuario.Email && senha == usuario.Senha)
                    {
                        this.Logado = true;
                        Console.WriteLine($"Login aceito !");

                    }

                }
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;

                    case "2":
                        produto.Listar();
                        break;

                    case "3":
                        Console.WriteLine($"Informe o código que deseja deletar: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":
                        Console.WriteLine($"Informe o código que deseja deletar: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;

                    case "0":
                        Console.WriteLine($"Encerrado!");
                        break;

                    default:
                        Console.WriteLine($"Invalido");
                        break;
                }
            } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "0");

        }

    }
}