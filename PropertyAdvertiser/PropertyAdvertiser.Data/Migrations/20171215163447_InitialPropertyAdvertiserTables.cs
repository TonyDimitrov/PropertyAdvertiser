namespace PropertyAdvertiser.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;

    public partial class InitialPropertyAdvertiserTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WorkForAgency",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "LettingsAds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertiserId = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: false),
                    ContactPhone = table.Column<string>(maxLength: 15, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PropertyName = table.Column<string>(maxLength: 50, nullable: false),
                    PropertyType = table.Column<int>(nullable: false),
                    ViewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LettingsAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LettingsAds_AspNetUsers_AdvertiserId",
                        column: x => x.AdvertiserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingAds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertiserId = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: false),
                    ContactPhone = table.Column<string>(maxLength: 15, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PropertyName = table.Column<string>(maxLength: 50, nullable: false),
                    PropertyType = table.Column<int>(nullable: false),
                    ViewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingAds_AspNetUsers_AdvertiserId",
                        column: x => x.AdvertiserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShortLettingAds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertiserId = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: false),
                    ContactPhone = table.Column<string>(maxLength: 15, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PropertyName = table.Column<string>(maxLength: 50, nullable: false),
                    PropertyType = table.Column<int>(nullable: false),
                    Stars = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortLettingAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortLettingAds_AspNetUsers_AdvertiserId",
                        column: x => x.AdvertiserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LettingAdvertisementId = table.Column<int>(nullable: false),
                    PictureUrl = table.Column<string>(nullable: false),
                    SellingAdvertisementId = table.Column<int>(nullable: false),
                    ShortLettingAdvertisementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_LettingsAds_LettingAdvertisementId",
                        column: x => x.LettingAdvertisementId,
                        principalTable: "LettingsAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Picture_SellingAds_SellingAdvertisementId",
                        column: x => x.SellingAdvertisementId,
                        principalTable: "SellingAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Picture_ShortLettingAds_ShortLettingAdvertisementId",
                        column: x => x.ShortLettingAdvertisementId,
                        principalTable: "ShortLettingAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LettingsAds_AdvertiserId",
                table: "LettingsAds",
                column: "AdvertiserId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_LettingAdvertisementId",
                table: "Picture",
                column: "LettingAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_SellingAdvertisementId",
                table: "Picture",
                column: "SellingAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_ShortLettingAdvertisementId",
                table: "Picture",
                column: "ShortLettingAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingAds_AdvertiserId",
                table: "SellingAds",
                column: "AdvertiserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortLettingAds_AdvertiserId",
                table: "ShortLettingAds",
                column: "AdvertiserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "LettingsAds");

            migrationBuilder.DropTable(
                name: "SellingAds");

            migrationBuilder.DropTable(
                name: "ShortLettingAds");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkForAgency",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
