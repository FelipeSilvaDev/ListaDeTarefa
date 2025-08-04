using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaDeTarefa.Migrations
{
    public partial class AddDescricaoToTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Tarefas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Tarefas");
        }
    }
}
