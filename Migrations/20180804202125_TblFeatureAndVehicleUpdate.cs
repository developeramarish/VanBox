using Microsoft.EntityFrameworkCore.Migrations;

namespace VanBox.Migrations
{
    public partial class TblFeatureAndVehicleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Makes_MakeId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Models_ModelId",
                table: "FeatureVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Features_FeatureId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_FeatureId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Features_MakeId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FeatureId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "FeatureVehicle",
                newName: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Vehicles_VehicleId",
                table: "FeatureVehicle",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Vehicles_VehicleId",
                table: "FeatureVehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "FeatureVehicle",
                newName: "ModelId");

            migrationBuilder.AddColumn<int>(
                name: "FeatureId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FeatureId",
                table: "Vehicles",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_MakeId",
                table: "Features",
                column: "MakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Makes_MakeId",
                table: "Features",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Models_ModelId",
                table: "FeatureVehicle",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Features_FeatureId",
                table: "Vehicles",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
