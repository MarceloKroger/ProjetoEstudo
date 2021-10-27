using System;
using Modelo;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Servicos servicos = new Servicos();
            PrecosServicos precos = new PrecosServicos();
            Barbeiro barbeiros = new Barbeiro();
            Produtos produtos = new Produtos();
            LocalFisico local = new LocalFisico();
            string resposta;

            do
            {

                Console.WriteLine("Para servicos digite 1");
                Console.WriteLine("Para produtos digite 2");
                Console.WriteLine("Para barbeiros digite 3");
                Console.WriteLine("Para precos digite 4");
                Console.WriteLine("Para local digite 5");
                Console.WriteLine("Para sair digite 0");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        for (int i = 0; i < servicos.Procedimentos.Length; i++)
                        {
                            Console.WriteLine(servicos.Procedimentos[i]);

                        }
                        break;

                    case "2":
                        Console.WriteLine("Qual tipo de produto voce deseja? Barba, Cabelo ou Bancada?");
                        string tipoProduto = Console.ReadLine();

                        switch (tipoProduto)
                        {
                            case "Barba":
                                for (int i = 0; i < produtos.ProdutosBarba.Length; i++)
                                {
                                    Console.WriteLine(produtos.ProdutosBarba[i]);
                                }
                                break;
                            case "Cabelo":
                                for (int i = 0; i < produtos.ProdutosCabelo.Length; i++)
                                {
                                    Console.WriteLine(produtos.ProdutosCabelo[i]);
                                }
                                break;
                            case "Bancada":
                                for (int i = 0; i < produtos.ProdutosBancada.Length; i++)
                                {
                                    Console.WriteLine(produtos.ProdutosBancada[i]);
                                }
                                break;
                        }
                        break;

                    case "3":
                        for (int i = 0; i < barbeiros.Equipe.Length; i++)
                        {
                            Console.WriteLine(barbeiros.Equipe[i]);
                            Console.WriteLine(barbeiros.TempoServico[i]);
                            Console.WriteLine(barbeiros.Anos[i]);
                            Console.WriteLine(barbeiros.ValorMensal[i]);
                        }
                        break;

                    case "4":
                        Console.WriteLine(precos.Corte);
                        Console.WriteLine(precos.Barboterapia);
                        Console.WriteLine(precos.DesignSobrancelha);
                        Console.WriteLine(precos.Nariz);
                        break;

                    case "5":
                        for (int i = 0; i < local.Local.Length; i++)
                        {
                            Console.WriteLine(local.Ferramentas[i]);
                            Console.WriteLine(local.Local[i]);
                            Console.WriteLine(local.Mobilia[i]);
                            Console.WriteLine(local.Branding[i]);
                        }
                        break;

                }

            } while (resposta == "0");
            Console.ReadLine();
        }
    }
}
