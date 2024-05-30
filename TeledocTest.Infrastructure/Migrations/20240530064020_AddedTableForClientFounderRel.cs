using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeledocTest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedTableForClientFounderRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFounder_Clients_LegalEntitiesId",
                table: "ClientFounder");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientFounder_Founders_FoundersId",
                table: "ClientFounder");

            migrationBuilder.RenameColumn(
                name: "LegalEntitiesId",
                table: "ClientFounder",
                newName: "FounderId");

            migrationBuilder.RenameColumn(
                name: "FoundersId",
                table: "ClientFounder",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientFounder_LegalEntitiesId",
                table: "ClientFounder",
                newName: "IX_ClientFounder_FounderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFounder_Clients_ClientId",
                table: "ClientFounder",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFounder_Founders_FounderId",
                table: "ClientFounder",
                column: "FounderId",
                principalTable: "Founders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFounder_Clients_ClientId",
                table: "ClientFounder");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientFounder_Founders_FounderId",
                table: "ClientFounder");

            migrationBuilder.RenameColumn(
                name: "FounderId",
                table: "ClientFounder",
                newName: "LegalEntitiesId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientFounder",
                newName: "FoundersId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientFounder_FounderId",
                table: "ClientFounder",
                newName: "IX_ClientFounder_LegalEntitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFounder_Clients_LegalEntitiesId",
                table: "ClientFounder",
                column: "LegalEntitiesId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFounder_Founders_FoundersId",
                table: "ClientFounder",
                column: "FoundersId",
                principalTable: "Founders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
