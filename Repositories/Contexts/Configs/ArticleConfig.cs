using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Contexts.Configs
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article { Id = 1, Title = "C#'a Giriş", Content = "C# moden bir programlama dilidir..."},
                new Article { Id = 2, Title = "Entity Framework Core", Content = "Entity Framework Core, .NET için bir ORM kütüphanesidir..."},
                new Article { Id = 3, Title = "ASP.NET Core", Content = "ASP.NET Core, web uygulamaları geliştirmek için kullanılan bir framework'tür..." },
                new Article { Id = 4, Title = "HTML", Content = "Web sitelerinin temelidir, bir şablon oluşturmak için kullanılır..."},
                new Article { Id = 5, Title = "CSS", Content = "Web sitelerinin görünümünü ve düzenini kontrol etmek için kullanılır..." },
                new Article { Id = 6, Title = "JavaScript", Content = "Web sitelerine etkileşim ve dinamik özellikler eklemek için kullanılır..." }
            );
        }
    }
}
