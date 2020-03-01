using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnotherHotel.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    reservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomRented = table.Column<string>(maxLength: 3, nullable: false),
                    userRegistrator = table.Column<int>(nullable: false),
                    dateOfAccomodation = table.Column<string>(nullable: false),
                    dateOfLeave = table.Column<string>(nullable: false),
                    includedBreakfast = table.Column<bool>(nullable: false),
                    allInclusive = table.Column<bool>(nullable: false),
                    priceOwed = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.reservationID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    roomID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    occupied = table.Column<bool>(nullable: false),
                    priceBedAdult = table.Column<double>(nullable: false),
                    priceBedChild = table.Column<double>(nullable: false),
                    number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.roomID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    middleName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    UCN = table.Column<string>(maxLength: 10, nullable: false),
                    telephoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    email = table.Column<string>(nullable: false),
                    hireDate = table.Column<DateTime>(nullable: false),
                    fireDate = table.Column<DateTime>(nullable: true),
                    active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    clientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    telephoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    email = table.Column<string>(nullable: false),
                    adult = table.Column<bool>(nullable: false),
                    reservationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.clientID);
                    table.ForeignKey(
                        name: "FK_Client_Reservation_reservationID",
                        column: x => x.reservationID,
                        principalTable: "Reservation",
                        principalColumn: "reservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_reservationID",
                table: "Client",
                column: "reservationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
