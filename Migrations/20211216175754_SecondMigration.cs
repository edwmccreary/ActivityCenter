using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityCenter.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinuteHourDay_Value",
                table: "Meetups");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MinuteHourDay_Value",
                table: "Meetups",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
