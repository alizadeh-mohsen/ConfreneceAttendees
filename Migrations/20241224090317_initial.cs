using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfreneceAttendees.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    referralSouerceId = table.Column<int>(type: "int", nullable: true),
                    ReferralId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    jobRoleId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendee_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendee_JobRole_jobRoleId",
                        column: x => x.jobRoleId,
                        principalTable: "JobRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendee_ReferralSouerce_referralSouerceId",
                        column: x => x.referralSouerceId,
                        principalTable: "ReferralSouerce",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendee_GenderId",
                table: "Attendee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendee_jobRoleId",
                table: "Attendee",
                column: "jobRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendee_referralSouerceId",
                table: "Attendee",
                column: "referralSouerceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendee");
        }
    }
}
