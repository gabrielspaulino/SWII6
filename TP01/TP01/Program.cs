using System;
using System.Collections.Generic;
using System.IO;
using TP01.model;

namespace TP01
{
    class Program
    {
        private static readonly string livrosPath = "C:\\Users\\Gabriel\\Desktop\\facul\\livros.csv";

        static void Main(string[] args)
        {
            List<Book> livros = new List<Book>();
            StreamReader reader = new StreamReader(livrosPath);
            using (var file = File.OpenText(livrosPath))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] livro = line.Split(", ");
                    List<string> autoresText = new List<string>();

                    for (int i = 3; i < livro.Length; i++)
                    {
                        autoresText.Add(livro.GetValue(livro.Length - i).ToString());
                    }

                    List<Author> autores = new List<Author>();
                    foreach(string autorText in autoresText)
                    {
                        string[] atributos = autorText.Split("; ");
                        Author autor = new Author(atributos[0], atributos[1], Convert.ToChar(atributos[2]));
                        autores.Add(autor);
                    }

                    livros.Add(new Book(livro[0], autores, Convert.ToDouble(livro[livro.Length - 2]), Convert.ToInt32(livro[livro.Length - 1])));
                }
            }
            Console.WriteLine("Livros:\n");
            foreach(Book livro in livros)
            {
                Console.WriteLine("\n" + livro.ToString());
                Console.WriteLine("Authors: " + livro.getAuthorNames());
            }
        }
    }
}
