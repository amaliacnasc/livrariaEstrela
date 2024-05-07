using System;
using System.Collections.Generic;

namespace SistemaLivraria {
    class Program {

        static void Main() {

            // Criando acervo inicial 
            List<Livro> livros = new List<Livro>();
            livros.Add(new Livro("Harry Potter", 500));
            livros.Add(new Livro("Guia SQL", 350));
            livros.Add(new Livro("O pequeno Príncipe", 134));

            // Criando menu da livraria
            Console.WriteLine("Bem vindo a livraria Estrela!\n");
            Console.WriteLine("Escolha a opção desejada\n1-Verificar acervo\n2-Pegar livro emprestado\n3-Doar livro\n4-Encerrar sistema");
            var menu = Convert.ToInt32(Console.ReadLine());

            switch (menu) {

                case 1:
                    // Exibindo todos os livros do acervo
                    foreach (Livro livro in livros) {
                        Console.WriteLine(livro);
                    }
                    break;

                case 2:
                    // Exibindo todos os livros do acervo
                    foreach (Livro livro in livros) {
                        Console.WriteLine(livro);
                    }
                    Console.WriteLine("Qual destes títulos você deseja pegar emprestado?");
                    string escolha = Console.ReadLine().ToUpper(); 
               
                        for (int i = livros.Count - 1; i >= 0; i--) {
                        if (livros[i].Titulo.ToUpper().Contains(escolha)) {
                            string livroEscolhido = livros[i].Titulo.ToUpper();
                            Console.WriteLine($"Você pegou {livroEscolhido} emprestado");
                            livros.RemoveAt(i); // removendo livro do acervo 
                        }
                    }

                    break;

                case 3:
                // Adicionando novo livro ao acervo
                Console.WriteLine("Ficamos felizes que você queira doar um livro à nossa biblioteca! Por favor, digite o título da obra\n");
                string livroDoado = Console.ReadLine(); 
                Console.WriteLine("Quantas páginas este livro tem?\n"); 
                int paginas = Convert.ToInt32((Console.ReadLine()));
                livros.Add(new Livro (livroDoado,paginas));
                Console.WriteLine("Muito Obrigada pela doação! Aqui está nosso acervo atualizado\n"); 
                foreach(Livro l in livros){
                    Console.WriteLine(l);
                }
                    break;

                case 4:
                Console.WriteLine("Encerrando sistema...\nSistema encerrado.");
                    break;

                default:
                    break;
            }
        }
    }
}
