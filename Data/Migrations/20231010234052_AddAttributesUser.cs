using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginRegister_MateoVelasquez.Data.Migrations
{
    public partial class AddAttributesUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNames",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
