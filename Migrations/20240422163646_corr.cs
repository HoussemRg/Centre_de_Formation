using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentreFormation.Migrations
{
    /// <inheritdoc />
    public partial class corr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cours",
                columns: table => new
                {
                    idCours = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomCours = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cours", x => x.idCours);
                });

            migrationBuilder.CreateTable(
                name: "Formateurs",
                columns: table => new
                {
                    idFormateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salaire = table.Column<double>(type: "float", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formateurs", x => x.idFormateur);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    idParticipant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    etatPayment = table.Column<bool>(type: "bit", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.idParticipant);
                });

            migrationBuilder.CreateTable(
                name: "salles",
                columns: table => new
                {
                    numSalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depatement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salles", x => x.numSalle);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    idFormation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomFormation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prixFormation = table.Column<double>(type: "float", nullable: false),
                    coursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.idFormation);
                    table.ForeignKey(
                        name: "FK_Formations_cours_coursId",
                        column: x => x.coursId,
                        principalTable: "cours",
                        principalColumn: "idCours",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sessions",
                columns: table => new
                {
                    idSession = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salleId = table.Column<int>(type: "int", nullable: false),
                    formateurId = table.Column<int>(type: "int", nullable: false),
                    formationId = table.Column<int>(type: "int", nullable: false),
                    duree = table.Column<int>(type: "int", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessions", x => x.idSession);
                    table.ForeignKey(
                        name: "FK_sessions_Formateurs_formateurId",
                        column: x => x.formateurId,
                        principalTable: "Formateurs",
                        principalColumn: "idFormateur",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sessions_Formations_formationId",
                        column: x => x.formationId,
                        principalTable: "Formations",
                        principalColumn: "idFormation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sessions_salles_salleId",
                        column: x => x.salleId,
                        principalTable: "salles",
                        principalColumn: "numSalle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantSession",
                columns: table => new
                {
                    participantsidParticipant = table.Column<int>(type: "int", nullable: false),
                    sessionsidSession = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantSession", x => new { x.participantsidParticipant, x.sessionsidSession });
                    table.ForeignKey(
                        name: "FK_ParticipantSession_Participants_participantsidParticipant",
                        column: x => x.participantsidParticipant,
                        principalTable: "Participants",
                        principalColumn: "idParticipant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantSession_sessions_sessionsidSession",
                        column: x => x.sessionsidSession,
                        principalTable: "sessions",
                        principalColumn: "idSession",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participation",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    IdParticipation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participation", x => new { x.ParticipantId, x.SessionId });
                    table.ForeignKey(
                        name: "FK_Participation_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "idParticipant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participation_sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "sessions",
                        principalColumn: "idSession",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formations_coursId",
                table: "Formations",
                column: "coursId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantSession_sessionsidSession",
                table: "ParticipantSession",
                column: "sessionsidSession");

            migrationBuilder.CreateIndex(
                name: "IX_Participation_SessionId",
                table: "Participation",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_sessions_formateurId",
                table: "sessions",
                column: "formateurId");

            migrationBuilder.CreateIndex(
                name: "IX_sessions_formationId",
                table: "sessions",
                column: "formationId");

            migrationBuilder.CreateIndex(
                name: "IX_sessions_salleId",
                table: "sessions",
                column: "salleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipantSession");

            migrationBuilder.DropTable(
                name: "Participation");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "sessions");

            migrationBuilder.DropTable(
                name: "Formateurs");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "salles");

            migrationBuilder.DropTable(
                name: "cours");
        }
    }
}
