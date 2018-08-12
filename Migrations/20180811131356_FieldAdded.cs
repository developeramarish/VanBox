using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class FieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Features_FeatureId",
                table: "FeatureVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Vehicles_VehicleId",
                table: "FeatureVehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeatureVehicle",
                table: "FeatureVehicle");

            migrationBuilder.RenameTable(
                name: "FeatureVehicle",
                newName: "FeatureVehicles");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Vehicles",
                newName: "ContactName");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureVehicle_FeatureId",
                table: "FeatureVehicles",
                newName: "IX_FeatureVehicles_FeatureId");

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactPhone",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegister",
                table: "Vehicles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeatureVehicles",
                table: "FeatureVehicles",
                columns: new[] { "VehicleId", "FeatureId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicles_Features_FeatureId",
                table: "FeatureVehicles",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicles_Vehicles_VehicleId",
                table: "FeatureVehicles",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicles_Features_FeatureId",
                table: "FeatureVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicles_Vehicles_VehicleId",
                table: "FeatureVehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeatureVehicles",
                table: "FeatureVehicles");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "IsRegister",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "FeatureVehicles",
                newName: "FeatureVehicle");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Vehicles",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureVehicles_FeatureId",
                table: "FeatureVehicle",
                newName: "IX_FeatureVehicle_FeatureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeatureVehicle",
                table: "FeatureVehicle",
                columns: new[] { "VehicleId", "FeatureId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Features_FeatureId",
                table: "FeatureVehicle",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Vehicles_VehicleId",
                table: "FeatureVehicle",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
