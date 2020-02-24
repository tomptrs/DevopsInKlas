using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LBI_DAL.Migrations
{
    public partial class tom1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Externe_bronDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Icone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SmallDescription = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    IsMail = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Forum = table.Column<string>(nullable: true),
                    Chat = table.Column<string>(nullable: true),
                    ChatLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Externe_bronDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HappinessDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmallDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HappinessDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MindfulnessDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MindfulnessDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuotesDb",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    quote = table.Column<string>(nullable: true),
                    tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesDb", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    FirstLoginStats = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EigenNetwerkDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nummer = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EigenNetwerkDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EigenNetwerkDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoalsDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Goal = table.Column<string>(nullable: true),
                    BeginTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Progress = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Percentage = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalsDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalsDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MomentKaderDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gedachte = table.Column<string>(nullable: true),
                    Emotie = table.Column<string>(nullable: true),
                    Lichaam = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MomentKaderDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MomentKaderDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statsdb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Week = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Good = table.Column<bool>(nullable: false),
                    Bad = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statsdb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statsdb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCategoryDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: true),
                    IdealValue = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategoryDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCategoryDb_CategoryDb_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCategoryDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHappinessDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    HappinessId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHappinessDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHappinessDb_HappinessDb_HappinessId",
                        column: x => x.HappinessId,
                        principalTable: "HappinessDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHappinessDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgendaItemDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    UserCategoryId = table.Column<int>(nullable: false),
                    AgendaId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaItemDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaItemDb_AgendaDb_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "AgendaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgendaItemDb_UserCategoryDb_UserCategoryId",
                        column: x => x.UserCategoryId,
                        principalTable: "UserCategoryDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<double>(nullable: false),
                    UserCategoryId = table.Column<int>(nullable: false),
                    StatId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogDb_Statsdb_StatId",
                        column: x => x.StatId,
                        principalTable: "Statsdb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogDb_UserCategoryDb_UserCategoryId",
                        column: x => x.UserCategoryId,
                        principalTable: "UserCategoryDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaDb_UserId",
                table: "AgendaDb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaItemDb_AgendaId",
                table: "AgendaItemDb",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaItemDb_UserCategoryId",
                table: "AgendaItemDb",
                column: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EigenNetwerkDb_UserId",
                table: "EigenNetwerkDb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalsDb_UserId",
                table: "GoalsDb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LogDb_StatId",
                table: "LogDb",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_LogDb_UserCategoryId",
                table: "LogDb",
                column: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MomentKaderDb_UserId",
                table: "MomentKaderDb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Statsdb_UserId",
                table: "Statsdb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategoryDb_CategoryId",
                table: "UserCategoryDb",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategoryDb_UserId",
                table: "UserCategoryDb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHappinessDb_HappinessId",
                table: "UserHappinessDb",
                column: "HappinessId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHappinessDb_UserId",
                table: "UserHappinessDb",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaItemDb");

            migrationBuilder.DropTable(
                name: "EigenNetwerkDb");

            migrationBuilder.DropTable(
                name: "Externe_bronDb");

            migrationBuilder.DropTable(
                name: "GoalsDb");

            migrationBuilder.DropTable(
                name: "LogDb");

            migrationBuilder.DropTable(
                name: "MindfulnessDb");

            migrationBuilder.DropTable(
                name: "MomentKaderDb");

            migrationBuilder.DropTable(
                name: "QuotesDb");

            migrationBuilder.DropTable(
                name: "UserHappinessDb");

            migrationBuilder.DropTable(
                name: "AgendaDb");

            migrationBuilder.DropTable(
                name: "Statsdb");

            migrationBuilder.DropTable(
                name: "UserCategoryDb");

            migrationBuilder.DropTable(
                name: "HappinessDb");

            migrationBuilder.DropTable(
                name: "CategoryDb");

            migrationBuilder.DropTable(
                name: "UsersDb");
        }
    }
}
