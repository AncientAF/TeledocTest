using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeledocTest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedAt", "Name", "TaxId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1c164bab-0747-40e2-b885-f1fec5440d42"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6423), "Client 4", "344461123113", 0, new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6423) },
                    { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6407), "Client 1", "1234567890", 1, new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6408) },
                    { new Guid("93aa14b2-6430-4bf3-bab7-3cd4fb92a804"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6424), "Client 5", "125678312356", 0, new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6425) },
                    { new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6421), "Client 3", "3456789012", 1, new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6422) },
                    { new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6420), "Client 2", "2345678901", 1, new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6420) }
                });

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "CreatedAt", "LastName", "MiddleName", "Name", "TaxId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6529), "L", "M", "Founder 1", "123456789022", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6529) },
                    { new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6533), "L", "M", "Founder 3", "345678901244", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6533) },
                    { new Guid("6d11dd64-336f-47df-8864-507b3fcc766e"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6536), "L", "M", "Founder 5", "345678901266", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6537) },
                    { new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6538), "L", "M", "Founder 6", "345678901277", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6539) },
                    { new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6531), "L", "M", "Founder 2", "234567890133", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6531) },
                    { new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959"), new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6535), "L", "M", "Founder 4", "234567890155", new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6535) }
                });

            migrationBuilder.InsertData(
                table: "ClientFounder",
                columns: new[] { "ClientId", "FounderId" },
                values: new object[,]
                {
                    { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790") },
                    { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b") },
                    { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5") },
                    { new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"), new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959") },
                    { new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"), new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f") },
                    { new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"), new Guid("6d11dd64-336f-47df-8864-507b3fcc766e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790") });

            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b") });

            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"), new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5") });

            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"), new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959") });

            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"), new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f") });

            migrationBuilder.DeleteData(
                table: "ClientFounder",
                keyColumns: new[] { "ClientId", "FounderId" },
                keyValues: new object[] { new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"), new Guid("6d11dd64-336f-47df-8864-507b3fcc766e") });

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1c164bab-0747-40e2-b885-f1fec5440d42"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("93aa14b2-6430-4bf3-bab7-3cd4fb92a804"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("6d11dd64-336f-47df-8864-507b3fcc766e"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959"));
        }
    }
}
