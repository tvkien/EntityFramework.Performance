using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Performance.Migrations
{
    public partial class Initdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngagementUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngagementUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngagementUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TermAndCondition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermAndCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermAndCondition_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email" },
                values: new object[] { new Guid("59ef6921-22bd-4c09-a982-2ed314992593"), "abc@abc.com" });

            migrationBuilder.InsertData(
                table: "EngagementUser",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("b756a857-cc5a-4d6e-ac0c-3decd23ffde9"), new Guid("59ef6921-22bd-4c09-a982-2ed314992593") },
                    { new Guid("c86c22de-85d0-4f22-8727-f6eb039adf12"), new Guid("59ef6921-22bd-4c09-a982-2ed314992593") }
                });

            migrationBuilder.InsertData(
                table: "TermAndCondition",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("802d598e-4ca9-4f23-850c-ca37f2450fb4"), new Guid("59ef6921-22bd-4c09-a982-2ed314992593") },
                    { new Guid("57808e40-bcf2-48f1-826a-59f0178a1dc7"), new Guid("59ef6921-22bd-4c09-a982-2ed314992593") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EngagementUser_UserId",
                table: "EngagementUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TermAndCondition_UserId",
                table: "TermAndCondition",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EngagementUser");

            migrationBuilder.DropTable(
                name: "TermAndCondition");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
