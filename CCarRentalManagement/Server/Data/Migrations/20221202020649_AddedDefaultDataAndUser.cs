using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "d4de3153-427e-49b8-8f56-9ca389d0ab78", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "55d8f2a2-c848-48f1-91c3-0183453d2c2b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "38118420-e4b4-4bb4-9655-49bceb568e7b", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENxmRtYyvR9EvnQeVRs4GVp7URujbrZ4poqtyGmUrsD2k9XrLKzTqvMt6BqXdEJcvA==", null, false, "1dbfcf91-acfb-4d53-ba02-5d1a5b0ecd8c", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 6, 48, 616, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 12, 2, 10, 6, 48, 623, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 6, 48, 624, DateTimeKind.Local).AddTicks(7327), new DateTime(2022, 12, 2, 10, 6, 48, 624, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 6, 48, 626, DateTimeKind.Local).AddTicks(9305), new DateTime(2022, 12, 2, 10, 6, 48, 626, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 6, 48, 626, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 12, 2, 10, 6, 48, 626, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3818), new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3826), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3831), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3835), new DateTime(2022, 12, 2, 10, 6, 48, 627, DateTimeKind.Local).AddTicks(3836), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 57, 39, 400, DateTimeKind.Local).AddTicks(5982), new DateTime(2022, 12, 2, 9, 57, 39, 401, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 57, 39, 402, DateTimeKind.Local).AddTicks(262), new DateTime(2022, 12, 2, 9, 57, 39, 402, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 57, 39, 403, DateTimeKind.Local).AddTicks(6153), new DateTime(2022, 12, 2, 9, 57, 39, 403, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 57, 39, 403, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 12, 2, 9, 57, 39, 403, DateTimeKind.Local).AddTicks(6176) });
        }
    }
}
