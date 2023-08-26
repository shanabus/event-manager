using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvManagerDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventRegistrations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventRegistrations",
                columns: table => new
                {
                    EventRegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admissions = table.Column<int>(type: "int", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InHouseDetox = table.Column<bool>(type: "bit", nullable: false),
                    TobaccoFree = table.Column<bool>(type: "bit", nullable: false),
                    MedicationAssistedTherapy = table.Column<bool>(type: "bit", nullable: false),
                    PatientsCaseManaged = table.Column<bool>(type: "bit", nullable: false),
                    AcceptInsurance = table.Column<bool>(type: "bit", nullable: false),
                    FinancialAid = table.Column<bool>(type: "bit", nullable: false),
                    Membership = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accredidation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientAgeRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: false),
                    YearsOpen = table.Column<int>(type: "int", nullable: false),
                    UniqueFeatures1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueFeatures2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueFeatures3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrations", x => x.EventRegistrationId);
                    table.ForeignKey(
                        name: "FK_EventRegistrations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId");
                });

            migrationBuilder.CreateTable(
                name: "Presenters",
                columns: table => new
                {
                    PresenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventRegistrationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presenters", x => x.PresenterId);
                    table.ForeignKey(
                        name: "FK_Presenters_EventRegistrations_EventRegistrationId",
                        column: x => x.EventRegistrationId,
                        principalTable: "EventRegistrations",
                        principalColumn: "EventRegistrationId");
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    EventRegistrationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentId);
                    table.ForeignKey(
                        name: "FK_Treatments_EventRegistrations_EventRegistrationId",
                        column: x => x.EventRegistrationId,
                        principalTable: "EventRegistrations",
                        principalColumn: "EventRegistrationId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrations_EventId",
                table: "EventRegistrations",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Presenters_EventRegistrationId",
                table: "Presenters",
                column: "EventRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_EventRegistrationId",
                table: "Treatments",
                column: "EventRegistrationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presenters");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "EventRegistrations");
        }
    }
}
