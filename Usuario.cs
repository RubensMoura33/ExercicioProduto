namespace Projeto_Menu_Produto
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {

            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Cadastro de Marcas e Produtos");
            Console.WriteLine($"------------------------------");


            Console.WriteLine($"Informe seu nome");
            this.Nome = Console.ReadLine();


            Console.WriteLine($"Insira um Email valido");
            this.Email = Console.ReadLine();


            Console.WriteLine($"Crie a sua senha");
            this.Senha = Console.ReadLine();

            this.DataCadastro = DateTime.Now;

            Console.WriteLine($"Cadastro concluido");

        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }


    }
}