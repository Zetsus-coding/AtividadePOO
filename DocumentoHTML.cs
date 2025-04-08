using System;

namespace FormatarDocumentos
{

    public class DocumentoHTML : Documento
    {
        //Construtor chamando o construtor da classe base
        public DocumentoHTML(string titulo, string autor, string dataCriacao) : base(titulo, autor, dataCriacao)
        { } //Posso deixar assim já que não tem nada mesmo, para encuntar (mesmo sendo 1 linha)

        //Métodos
        public override void Imprimir()
        {
            Console.WriteLine("Titulo da Obra:" + titulo + ";\n" +
                              "Nome do autor: " + autor + ";\n" +
                              "Ano de publicação \"origina\": " + dataCriacao);
        }
        public override string ConteudoFormatado()
        {
            return ("Conteúdo \"formatado\" com sucesso (html)"
                    + Environment.NewLine + Environment.NewLine +
                    "Resultado: " + Imprimir());
        }

        public void AdicionarEstilo(string css)
        {
            //titulo = "<style>" + css + "</style>";
        }
    }
}