using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Meter.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Initital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastIndex = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastIndexDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeasurementVoltage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeasurementCurrent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "Id", "LastIndex", "LastIndexDate", "MeasurementCurrent", "MeasurementVoltage", "SerialNumber" },
                values: new object[,]
                {
                    { new Guid("0d47b8de-fdf2-4500-9f71-4c676ba44ee1"), 4.72249286186685m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7883), 1.37182939011335m, 1.29969700202157m, "SN887722" },
                    { new Guid("2364449e-fbcd-49f3-b2d3-8f1098f031f1"), 8.66340592418833m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7888), 3.1775551015712m, 1.60702593746998m, "SN807362" },
                    { new Guid("297a745d-d73e-43b8-8d87-9e69ba9eb08d"), 6.5880160043172m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7870), 7.4671873759133m, 5.40369910542006m, "SN836354" },
                    { new Guid("441eb1a4-17de-4868-9c8a-265456bac20b"), 2.06604843651495m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7826), 6.62477750730384m, 8.7274816753189m, "SN389388" },
                    { new Guid("4d4e797e-16dc-4d8b-81fb-17d7ed4d96e2"), 41.3108731490067m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7807), 5.04984144233824m, 7.48404574730343m, "SN480359" },
                    { new Guid("70a994b6-11d8-4362-b1b3-1ff56105b82a"), 8.16607372102124m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7865), 6.03649989569376m, 3.45010845998231m, "SN500042" },
                    { new Guid("85e3ee1f-e28c-4ea8-9dec-e8b38f29121f"), 43.0376005743783m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7898), 4.25376303377939m, 2.16610460484716m, "SN266653" },
                    { new Guid("a04ada71-d73f-43ec-9c5a-3149562545c0"), 12.5456883078097m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7831), 4.34623249650769m, 2.18874399603874m, "SN469294" },
                    { new Guid("b7792b85-8eff-453e-86fa-e7b7b8d12f37"), 34.0097600874116m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7878), 1.04471281941103m, 6.41905284716454m, "SN699305" },
                    { new Guid("c15ea22a-0093-405f-aab9-f33986c48d4e"), 5.36679776261033m, new DateTime(2024, 10, 30, 1, 14, 35, 899, DateTimeKind.Local).AddTicks(7893), 5.71476173932756m, 2.56827631521461m, "SN313486" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meters");
        }
    }
}
