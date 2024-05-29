using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeledocTest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Founders_TaxId",
                table: "Founders");

            migrationBuilder.DropIndex(
                name: "IX_Clients_TaxId",
                table: "Clients");

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

            migrationBuilder.CreateIndex(
                name: "IX_Founders_TaxId",
                table: "Founders",
                column: "TaxId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TaxId",
                table: "Clients",
                column: "TaxId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Founders_TaxId",
                table: "Founders");

            migrationBuilder.DropIndex(
                name: "IX_Clients_TaxId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LegalEntitiesIds",
                table: "Founders");

            migrationBuilder.DropColumn(
                name: "FoundersIds",
                table: "Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Founders_TaxId",
                table: "Founders",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TaxId",
                table: "Clients",
                column: "TaxId");
        }
    }
}
