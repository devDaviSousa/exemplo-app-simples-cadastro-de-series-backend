using System;

namespace DIO.Series
{
  class Program
  {
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main(string[] args)
    {

      string opcaoUsuario = ObeterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "x")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            //AtualizarSerie();
            break;
          case "4":
            //ExcluirSerie();
            break;
          case "5":
            //VisualizarSerie();
            break;
          case "c":
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObeterOpcaoUsuario();
      }
      Console.WriteLine("Obrigado por Utilizar nossos serviços");
      Console.ReadLine();
    }

    private static void ListarSeries()
    {
      Console.WriteLine("Listar series");
      var lista = repositorio.Lista();

      if (lista.Count == 0)
      {
        Console.WriteLine("Nenhuma serie cadastrada");
      }

      foreach (var serie in lista)
      {
        Console.WriteLine("#ID {0} : - {1}", serie.retornaId(), serie.retornaTitulo());
      }


    }

    private static void InserirSerie()
    {
      Console.WriteLine("Inserir nova serie");

      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
      }

      Console.WriteLine("Digite o genero entre as opções acimea:");
      int entradaGenero = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o Titulo da Serie: ");
      string entradaTitulo = Console.ReadLine();

      Console.WriteLine("Digite o Ano de Inicio da Serie: ");
      int entradaAno = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite a Descrição da Serie: ");
      string entradaDescricao = Console.ReadLine();

      Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

      repositorio.Insere(novaSerie);
    }
    private static string ObeterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("MINHAS SERIES");
      Console.WriteLine("===============");
      Console.WriteLine("Digite a opção desejada:");
      Console.WriteLine();
      Console.WriteLine("1 - Listar series");
      Console.WriteLine("2 - Inserir nova serie");
      Console.WriteLine("3 - Atualizar serie");
      Console.WriteLine("4 - Excluir serie");
      Console.WriteLine("5 - Visualizar serie");
      Console.WriteLine("C - Limpar a tela");
      Console.WriteLine("X - Sair");

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();

      return opcaoUsuario;


    }
  }
}
