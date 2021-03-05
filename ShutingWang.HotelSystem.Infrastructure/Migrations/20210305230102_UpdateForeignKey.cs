using Microsoft.EntityFrameworkCore.Migrations;

namespace ShutingWang.HotelSystem.Infrastructure.Migrations
{
    public partial class UpdateForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Room_RoomId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Roomtype_RoomtypeId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Room_RoomId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_RoomId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Room_RoomtypeId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RoomId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "RoomtypeId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Service_RoomNo",
                table: "Service",
                column: "RoomNo");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RtCode",
                table: "Room",
                column: "RtCode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RoomNo",
                table: "Customer",
                column: "RoomNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Room_RoomNo",
                table: "Customer",
                column: "RoomNo",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Roomtype_RtCode",
                table: "Room",
                column: "RtCode",
                principalTable: "Roomtype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Room_RoomNo",
                table: "Service",
                column: "RoomNo",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Room_RoomNo",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Roomtype_RtCode",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Room_RoomNo",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_RoomNo",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Room_RtCode",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RoomNo",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomtypeId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_RoomId",
                table: "Service",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomtypeId",
                table: "Room",
                column: "RoomtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RoomId",
                table: "Customer",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Room_RoomId",
                table: "Customer",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Roomtype_RoomtypeId",
                table: "Room",
                column: "RoomtypeId",
                principalTable: "Roomtype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Room_RoomId",
                table: "Service",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
