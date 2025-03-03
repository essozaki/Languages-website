using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Languagyproject.Migrations
{
    /// <inheritdoc />
    public partial class DataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeaturesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArFeaturesDescription = table.Column<string>(name: "Ar_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    FrFeaturesDescription = table.Column<string>(name: "Fr_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    italFeaturesDescription = table.Column<string>(name: "ital_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    TurFeaturesDescription = table.Column<string>(name: "Tur_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    GerFeaturesDescription = table.Column<string>(name: "Ger_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    RomFeaturesDescription = table.Column<string>(name: "Rom_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    EspFeaturesDescription = table.Column<string>(name: "Esp_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    ChinesFeaturesDescription = table.Column<string>(name: "Chines_FeaturesDescription", type: "nvarchar(max)", nullable: false),
                    FilipFeaturesDescription = table.Column<string>(name: "Filip_FeaturesDescription", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Header",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArHeaderTitle = table.Column<string>(name: "Ar_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    FrHeaderTitle = table.Column<string>(name: "Fr_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    italHeaderTitle = table.Column<string>(name: "ital_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    TurHeaderTitle = table.Column<string>(name: "Tur_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    GerHeaderTitle = table.Column<string>(name: "Ger_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    RomHeaderTitle = table.Column<string>(name: "Rom_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    EspHeaderTitle = table.Column<string>(name: "Esp_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    ChinesHeaderTitle = table.Column<string>(name: "Chines_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    FilipHeaderTitle = table.Column<string>(name: "Filip_HeaderTitle", type: "nvarchar(max)", nullable: false),
                    HeaderDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArHeaderDescription = table.Column<string>(name: "Ar_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    FrHeaderDescription = table.Column<string>(name: "Fr_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    italHeaderDescription = table.Column<string>(name: "ital_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    TurHeaderDescription = table.Column<string>(name: "Tur_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    GerHeaderDescription = table.Column<string>(name: "Ger_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    RomHeaderDescription = table.Column<string>(name: "Rom_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    EspHeaderDescription = table.Column<string>(name: "Esp_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    ChinesHeaderDescription = table.Column<string>(name: "Chines_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    FilipHeaderDescription = table.Column<string>(name: "Filip_HeaderDescription", type: "nvarchar(max)", nullable: false),
                    HeaderImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Header", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArMemberName = table.Column<string>(name: "Ar_MemberName", type: "nvarchar(max)", nullable: false),
                    FrMemberName = table.Column<string>(name: "Fr_MemberName", type: "nvarchar(max)", nullable: false),
                    italMemberName = table.Column<string>(name: "ital_MemberName", type: "nvarchar(max)", nullable: false),
                    TurMemberName = table.Column<string>(name: "Tur_MemberName", type: "nvarchar(max)", nullable: false),
                    GerMemberName = table.Column<string>(name: "Ger_MemberName", type: "nvarchar(max)", nullable: false),
                    RomMemberName = table.Column<string>(name: "Rom_MemberName", type: "nvarchar(max)", nullable: false),
                    EspMemberName = table.Column<string>(name: "Esp_MemberName", type: "nvarchar(max)", nullable: false),
                    ChinesMemberName = table.Column<string>(name: "Chines_MemberName", type: "nvarchar(max)", nullable: false),
                    FilipMemberName = table.Column<string>(name: "Filip_MemberName", type: "nvarchar(max)", nullable: false),
                    MemberTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArMemberTitle = table.Column<string>(name: "Ar_MemberTitle", type: "nvarchar(max)", nullable: false),
                    FrMemberTitle = table.Column<string>(name: "Fr_MemberTitle", type: "nvarchar(max)", nullable: false),
                    italMemberTitle = table.Column<string>(name: "ital_MemberTitle", type: "nvarchar(max)", nullable: false),
                    TurMemberTitle = table.Column<string>(name: "Tur_MemberTitle", type: "nvarchar(max)", nullable: false),
                    GerMemberTitle = table.Column<string>(name: "Ger_MemberTitle", type: "nvarchar(max)", nullable: false),
                    RomMemberTitle = table.Column<string>(name: "Rom_MemberTitle", type: "nvarchar(max)", nullable: false),
                    EspMemberTitle = table.Column<string>(name: "Esp_MemberTitle", type: "nvarchar(max)", nullable: false),
                    ChinesMemberTitle = table.Column<string>(name: "Chines_MemberTitle", type: "nvarchar(max)", nullable: false),
                    FilipMemberTitle = table.Column<string>(name: "Filip_MemberTitle", type: "nvarchar(max)", nullable: false),
                    MemberImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnersLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArQuest = table.Column<string>(name: "Ar_Quest", type: "nvarchar(max)", nullable: false),
                    FrQuest = table.Column<string>(name: "Fr_Quest", type: "nvarchar(max)", nullable: false),
                    italQuest = table.Column<string>(name: "ital_Quest", type: "nvarchar(max)", nullable: false),
                    TurQuest = table.Column<string>(name: "Tur_Quest", type: "nvarchar(max)", nullable: false),
                    GerQuest = table.Column<string>(name: "Ger_Quest", type: "nvarchar(max)", nullable: false),
                    RomQuest = table.Column<string>(name: "Rom_Quest", type: "nvarchar(max)", nullable: false),
                    EspQuest = table.Column<string>(name: "Esp_Quest", type: "nvarchar(max)", nullable: false),
                    ChinesQuest = table.Column<string>(name: "Chines_Quest", type: "nvarchar(max)", nullable: false),
                    FilipQuest = table.Column<string>(name: "Filip_Quest", type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArAnswer = table.Column<string>(name: "Ar_Answer", type: "nvarchar(max)", nullable: false),
                    FrAnswer = table.Column<string>(name: "Fr_Answer", type: "nvarchar(max)", nullable: false),
                    italAnswer = table.Column<string>(name: "ital_Answer", type: "nvarchar(max)", nullable: false),
                    TurAnswer = table.Column<string>(name: "Tur_Answer", type: "nvarchar(max)", nullable: false),
                    GerAnswer = table.Column<string>(name: "Ger_Answer", type: "nvarchar(max)", nullable: false),
                    RomAnswer = table.Column<string>(name: "Rom_Answer", type: "nvarchar(max)", nullable: false),
                    EspAnswer = table.Column<string>(name: "Esp_Answer", type: "nvarchar(max)", nullable: false),
                    ChinesAnswer = table.Column<string>(name: "Chines_Answer", type: "nvarchar(max)", nullable: false),
                    FilipAnswer = table.Column<string>(name: "Filip_Answer", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArThemeTitle = table.Column<string>(name: "Ar_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    FrThemeTitle = table.Column<string>(name: "Fr_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    italThemeTitle = table.Column<string>(name: "ital_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    TurThemeTitle = table.Column<string>(name: "Tur_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    GerThemeTitle = table.Column<string>(name: "Ger_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    RomThemeTitle = table.Column<string>(name: "Rom_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    EspThemeTitle = table.Column<string>(name: "Esp_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    ChinesThemeTitle = table.Column<string>(name: "Chines_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    FilipThemeTitle = table.Column<string>(name: "Filip_ThemeTitle", type: "nvarchar(max)", nullable: false),
                    ThemeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArThemeDescription = table.Column<string>(name: "Ar_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    FrThemeDescription = table.Column<string>(name: "Fr_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    italThemeDescription = table.Column<string>(name: "ital_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    TurThemeDescription = table.Column<string>(name: "Tur_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    GerThemeDescription = table.Column<string>(name: "Ger_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    RomThemeDescription = table.Column<string>(name: "Rom_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    EspThemeDescription = table.Column<string>(name: "Esp_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    ChinesThemeDescription = table.Column<string>(name: "Chines_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    FilipThemeDescription = table.Column<string>(name: "Filip_ThemeDescription", type: "nvarchar(max)", nullable: false),
                    ThemeImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Welcome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WelcomeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArWelcomeDescription = table.Column<string>(name: "Ar_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    FrWelcomeDescription = table.Column<string>(name: "Fr_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    italWelcomeDescription = table.Column<string>(name: "ital_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    TurWelcomeDescription = table.Column<string>(name: "Tur_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    GerWelcomeDescription = table.Column<string>(name: "Ger_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    RomWelcomeDescription = table.Column<string>(name: "Rom_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    EspWelcomeDescription = table.Column<string>(name: "Esp_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    ChinesWelcomeDescription = table.Column<string>(name: "Chines_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    FilipWelcomeDescription = table.Column<string>(name: "Filip_WelcomeDescription", type: "nvarchar(max)", nullable: false),
                    WelcomeIImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welcome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactUS");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Header");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "Welcome");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
