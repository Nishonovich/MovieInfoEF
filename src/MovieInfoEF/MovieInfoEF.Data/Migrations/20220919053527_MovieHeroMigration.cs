using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieInfoEF.Data.Migrations
{
    public partial class MovieHeroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeroName",
                table: "MovieHeroes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeroName",
                table: "MovieHeroes",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");
        }
    }
}
