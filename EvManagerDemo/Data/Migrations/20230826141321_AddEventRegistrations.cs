using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvManagerDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventRegistrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDays_Events_EventId",
                table: "EventDays");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_EventDays_DayEventDayId",
                table: "TimeSlots");

            migrationBuilder.AlterColumn<int>(
                name: "DayEventDayId",
                table: "TimeSlots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "EventDays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDays_Events_EventId",
                table: "EventDays",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_EventDays_DayEventDayId",
                table: "TimeSlots",
                column: "DayEventDayId",
                principalTable: "EventDays",
                principalColumn: "EventDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDays_Events_EventId",
                table: "EventDays");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_EventDays_DayEventDayId",
                table: "TimeSlots");

            migrationBuilder.AlterColumn<int>(
                name: "DayEventDayId",
                table: "TimeSlots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "EventDays",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDays_Events_EventId",
                table: "EventDays",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_EventDays_DayEventDayId",
                table: "TimeSlots",
                column: "DayEventDayId",
                principalTable: "EventDays",
                principalColumn: "EventDayId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
