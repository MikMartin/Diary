using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Diary.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteId", "NoteDate", "NoteDescription", "NoteName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.", "Porada" },
                    { 2, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.", "uzávěrka" },
                    { 3, new DateTime(1923, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.", "Porada" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
