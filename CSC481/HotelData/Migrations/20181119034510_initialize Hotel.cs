using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelData.Migrations
{
    public partial class initializeHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<string>(nullable: false),
                    ExtraItemsName = table.Column<string>(nullable: false),
                    FinalPrice = table.Column<double>(nullable: false),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "WaitingLists",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CheckTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaitingLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelInfos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CustomerStatus = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    WaitingListId = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<string>(maxLength: 9, nullable: true),
                    StaffPosition = table.Column<int>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelInfos_WaitingLists_WaitingListId",
                        column: x => x.WaitingListId,
                        principalTable: "WaitingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<string>(nullable: false),
                    street = table.Column<string>(maxLength: 50, nullable: false),
                    AptNumber = table.Column<string>(maxLength: 5, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    HotelInfoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_HotelInfos_HotelInfoId",
                        column: x => x.HotelInfoId,
                        principalTable: "HotelInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ELastName = table.Column<string>(maxLength: 20, nullable: false),
                    EFirstName = table.Column<string>(maxLength: 20, nullable: false),
                    EPhone = table.Column<string>(maxLength: 10, nullable: false),
                    RelativeToStaff = table.Column<string>(maxLength: 20, nullable: false),
                    StaffId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContacts_HotelInfos_StaffId",
                        column: x => x.StaffId,
                        principalTable: "HotelInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymenInfos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CardNumber = table.Column<string>(maxLength: 16, nullable: false),
                    CardType = table.Column<string>(maxLength: 25, nullable: false),
                    SecurityCode = table.Column<string>(maxLength: 8, nullable: false),
                    MonthExpired = table.Column<string>(maxLength: 2, nullable: false),
                    YearExpired = table.Column<string>(maxLength: 2, nullable: false),
                    HotelInfoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymenInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymenInfos_HotelInfos_HotelInfoId",
                        column: x => x.HotelInfoId,
                        principalTable: "HotelInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ConfirmationNumber = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: false),
                    Datebooking = table.Column<DateTime>(nullable: false),
                    DateRegisterCheckIn = table.Column<DateTime>(nullable: false),
                    DateRegistercheckOut = table.Column<DateTime>(nullable: false),
                    IsCheckIn = table.Column<bool>(nullable: false),
                    isCheckOut = table.Column<bool>(nullable: false),
                    BillId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ConfirmationNumber);
                    table.ForeignKey(
                        name: "FK_Reservations_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_HotelInfos_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "HotelInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelAssets",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(maxLength: 3, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SizeBed = table.Column<string>(nullable: false),
                    TypeRoom = table.Column<string>(nullable: false),
                    RoomCondition = table.Column<string>(nullable: false),
                    StatusRoom = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ReservationsConfirmationNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAssets", x => x.RoomNumber);
                    table.ForeignKey(
                        name: "FK_HotelAssets_Reservations_ReservationsConfirmationNumber",
                        column: x => x.ReservationsConfirmationNumber,
                        principalTable: "Reservations",
                        principalColumn: "ConfirmationNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_HotelInfoId",
                table: "Addresses",
                column: "HotelInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContacts_StaffId",
                table: "EmergencyContacts",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelAssets_ReservationsConfirmationNumber",
                table: "HotelAssets",
                column: "ReservationsConfirmationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_HotelInfos_WaitingListId",
                table: "HotelInfos",
                column: "WaitingListId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymenInfos_HotelInfoId",
                table: "PaymenInfos",
                column: "HotelInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BillId",
                table: "Reservations",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "HotelAssets");

            migrationBuilder.DropTable(
                name: "PaymenInfos");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "HotelInfos");

            migrationBuilder.DropTable(
                name: "WaitingLists");
        }
    }
}
