﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheGioiBiDong.Migrations
{
    /// <inheritdoc />
    public partial class initUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
