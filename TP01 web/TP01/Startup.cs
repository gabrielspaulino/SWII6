using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TP01.repository;
using TP01.model;

namespace TP01
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("Livro/Nome/{nome}", buscaNomeLivro);
            builder.MapRoute("Livro/Info/{nome}", buscaLivro);
            builder.MapRoute("Livro/NomeAutores/{nome}", buscaAutores);
            builder.MapRoute("Livro/ApresentarLivro/{nome}", apresentaLivro);
            var rotas = builder.Build();

            app.UseRouter(rotas);
        }

        public Task buscaNomeLivro(HttpContext context)
        {
            try
            {
                var name = context.GetRouteValue("nome").ToString();
                BookCsv bookCsv = new BookCsv();
                var books = bookCsv.getBooks();
                var book = procuraLivro(books, name);
                return context.Response.WriteAsync(book.getName());
            }
            catch (Exception)
            {
                return context.Response.WriteAsync("Nome de livro inexistente.");
            }
        }

        public Task buscaLivro(HttpContext context)
        {
            try
            {
                var name = context.GetRouteValue("nome").ToString();
                BookCsv bookCsv = new BookCsv();
                var books = bookCsv.getBooks();
                var book = procuraLivro(books, name);
                if (book == null)
                {
                    return context.Response.WriteAsync("Nome de livro inexistente.");
                }
                var conteudo = CarregandoHTML();
                conteudo = conteudo.Replace("#LISTA#", $"<li>{book.getName()}</li>" +
                    $"<li>{book.getAuthorNames()}</li>" +
                    $"<li>{book.getPrice()}</li>" +
                    $"<li>{book.getQty()}</li></br>");
                return context.Response.WriteAsync(conteudo);
            }
            catch (Exception)
            {
                return context.Response.WriteAsync("Nome de livro inexistente.");
            }
        }

        public Task buscaAutores(HttpContext context)
        {
            try
            {
                var name = context.GetRouteValue("nome").ToString();
                BookCsv bookCsv = new BookCsv();
                var books = bookCsv.getBooks();
                var book = procuraLivro(books, name);
                return context.Response.WriteAsync(book.getAuthorNames());
            }
            catch (Exception)
            {
                return context.Response.WriteAsync("Nome de livro inexistente.");
            }
        }

        public Task apresentaLivro(HttpContext context)
        {
            try
            {
                var name = context.GetRouteValue("nome").ToString();
                BookCsv bookCsv = new BookCsv();
                var books = bookCsv.getBooks();
                var book = procuraLivro(books, name);
                return context.Response.WriteAsync(book.getName() + "\nAutores: " + book.getAuthorNames());
            }
            catch (Exception)
            {
                return context.Response.WriteAsync("Nome de livro inexistente.");
            }
        }

        private string CarregandoHTML()
        {
            var nomeCompletoArquivo = $"../../../htmlPage/Books.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }

        private Book procuraLivro(List<Book> books, string name)
        {
            foreach(Book book in books)
            {
                if (book.getName().Equals(name))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
