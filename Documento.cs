using System;

namespace FormatarDocumentos
{
    public class Documento
    {
        //Propriedades
        public string titulo { get; set; }
        public string autor { get; set; }
        public string dataCriacao { get; set; }

        //Construtor
        public Documento(string titulo, string autor, string dataCriacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.dataCriacao = dataCriacao;
        }

        //Métodos
        public virtual void Imprimir()
        {
            Console.WriteLine("Titulo:" + titulo + "; Nome do autor: " + autor + "; Ano de publicação/criação: " + dataCriacao);
        }

        public virtual string ConteudoFormatado() //Formatei desse jeito para tentar deixar mais legível(?) e não ficar tão longo (fazendo um teste)
        {
            return ("Titulo:" + titulo + "; Nome do autor: " + autor + "; Ano de publicação/criação: " + dataCriacao);
        }
    }
}

