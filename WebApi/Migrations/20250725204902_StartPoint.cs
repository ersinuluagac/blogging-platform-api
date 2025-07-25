using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class StartPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "C# moden bir programlama dilidir...", "C#'a Giriş" },
                    { 2, "Entity Framework Core, .NET için bir ORM kütüphanesidir...", "Entity Framework Core" },
                    { 3, "ASP.NET Core, web uygulamaları geliştirmek için kullanılan bir framework'tür...", "ASP.NET Core" },
                    { 4, "Web sitelerinin temelidir, bir şablon oluşturmak için kullanılır...", "HTML" },
                    { 5, "Web sitelerinin görünümünü ve düzenini kontrol etmek için kullanılır...", "CSS" },
                    { 6, "Web sitelerine etkileşim ve dinamik özellikler eklemek için kullanılır...", "JavaScript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
