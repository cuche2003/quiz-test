using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JSQuizTest.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminSecurityStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5475bf40-0c02-4863-abe4-c4202c58eb3a", "AQAAAAIAAYagAAAAEIZRVKggwevzS70KaXtwKWliZkkKX9CWPv2izE37Yz7ZXkPSVgCq3PuqSM5bPILoCg==", "23bed65c-b62c-482b-9afa-d9174ec6ac20" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d90fff0-b050-4182-938f-c5aa35e2195b", "AQAAAAIAAYagAAAAECN4o3lUNCGasQPKAw2eoFsb/QFzzmMVbYdqoAatGMEFZ/8fSFX6MQa5FfX/WBShFQ==", "" });
        }
    }
}
