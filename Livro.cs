using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaLivraria
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public int? NPaginas { get; set; }

        public Livro(string titulo, int nPaginas)
        {
            Titulo = titulo;
            NPaginas = nPaginas;
        }
         public override string ToString() {
            return $"Título: {Titulo}, Páginas: {NPaginas}";
    }
}}