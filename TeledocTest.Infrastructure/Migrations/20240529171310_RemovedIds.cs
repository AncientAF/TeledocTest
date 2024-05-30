using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeledocTest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LegalEntitiesIds",
                table: "Founders");

            migrationBuilder.DropColumn(
                name: "FoundersIds",
                table: "Clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid[]>(
                name: "LegalEntitiesIds",
                table: "Founders",
                type: "uuid[]",
                nullable: true);

            migrationBuilder.AddColumn<Guid[]>(
                name: "FoundersIds",
                table: "Clients",
                type: "uuid[]",
                nullable: true);
        }
    }
}
