using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManegment.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BookCover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BookCover", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_BookCover_Tbl_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Tbl_Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookCoverId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Book_Tbl_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Tbl_Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Book_Tbl_BookCover_BookCoverId",
                        column: x => x.BookCoverId,
                        principalTable: "Tbl_BookCover",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Book_AuthorId",
                table: "Tbl_Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Book_BookCoverId",
                table: "Tbl_Book",
                column: "BookCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BookCover_AuthorId",
                table: "Tbl_BookCover",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Book");

            migrationBuilder.DropTable(
                name: "Tbl_BookCover");

            migrationBuilder.DropTable(
                name: "Tbl_Author");
        }
    }
}
