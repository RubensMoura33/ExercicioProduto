namespace Projeto_Menu_Produto
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {

            Marca novaMarca = new Marca();

            Console.WriteLine($"Informe o codigo da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();

            listaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar()

        {
            foreach (var novaMarca in listaDeMarcas)
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Codigo da Marca: {novaMarca.Codigo}");
                Console.WriteLine($"Nome da Marca: {novaMarca.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {novaMarca.DataCadastro}");
                Console.WriteLine($"-------------------");

            }
        }

        public void Deletar(int codigo)
        {
            Marca marca = listaDeMarcas.Find(x => x.Codigo == codigo);
            listaDeMarcas.Remove(marca);
        }
    }
}