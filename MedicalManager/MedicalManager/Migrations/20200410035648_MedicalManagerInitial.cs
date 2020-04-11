using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalManager.Migrations
{
    public partial class MedicalManagerInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Dose = table.Column<string>(nullable: false),
                    Administer = table.Column<int>(nullable: false),
                    Prescribed = table.Column<DateTime>(nullable: false),
                    Refills = table.Column<int>(nullable: false),
                    Prescriber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medications");
        }
    }
}
