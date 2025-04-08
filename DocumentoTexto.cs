using System;

namespace FormatarDocumentos
{

    public class DocumentoTexto : Documento
    {
        //Construtor chamando o construtor da classe base
        public DocumentoTexto(string titulo, string autor, string dataCriacao) : base(titulo, autor, dataCriacao)
        {
        }

        //Métodos
        public override void Imprimir()
        {
            Console.WriteLine($"Titulo da Obra: {titulo};");
            Console.WriteLine($"Nome do autor: {autor};");
            Console.WriteLine($"Ano de publicação \"origina\": {dataCriacao};");
        }

        public override string ConteudoFormatado()
        {
            return ("Conteúdo \"formatado\" com sucesso (txt)");
        }

        public void ContarPalavras()
        {
            //titulo.Split(' ').Length;
        }
    }
}