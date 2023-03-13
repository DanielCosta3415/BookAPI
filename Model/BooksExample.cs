using Swashbuckle.AspNetCore.Filters;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection;

namespace BookAPI.Model
{
    public class BooksExample : IExamplesProvider<Book>
    {
        public Book GetExamples()
        {
            return new Book
            {
                Id = 1,
                Author = "Daniel Costa",
                Description = "Livro de Programação I",
                Title = "Programando em C#"
            };
        }
    }
}
