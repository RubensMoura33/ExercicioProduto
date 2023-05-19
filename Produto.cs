namespace Projeto_Menu_Produto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastroPor { get; set; }

        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto NovoProduto = new Produto();

            Console.WriteLine($"Informe o codigo do produto");
            NovoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto");
            NovoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Informe o preco do produto");
            NovoProduto.Preco = float.Parse(Console.ReadLine());

            listaDeProdutos.Add(NovoProduto);

            Console.WriteLine($"Informe o Codigo da Marca do produto:");
            int CodigoDaMarca = int.Parse(Console.ReadLine());

            Marca marca = Marca.listaDeMarcas.Find(x => x.Codigo == CodigoDaMarca);

            if (marca != null)
            {
                NovoProduto.Marca = marca;
            }
            else
            {
                Console.WriteLine($"Marca nao cadastrada, cadastre a marca");
               
            }

        }

        public void Listar()
        {
                        foreach (var NovoProduto in listaDeProdutos)
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Codigo da Marca: {NovoProduto.Codigo}");
                Console.WriteLine($"Nome da Marca: {NovoProduto.NomeProduto}");
                Console.WriteLine($"Data do cadastro: {NovoProduto.DataCadastro}");
                Console.WriteLine($"-------------------");

            }

        }

        public void Deletar(int codigo)
        {
            Produto produto = listaDeProdutos.Find(x => x.Codigo == codigo);
            listaDeProdutos.Remove(produto);
 
        }

    }
}