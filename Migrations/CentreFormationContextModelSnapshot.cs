﻿// <auto-generated />
using System;
using CentreFormation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CentreFormation.Migrations
{
    [DbContext(typeof(CentreFormationContext))]
    partial class CentreFormationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CentreFormation.Models.Participation", b =>
                {
                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("IdParticipation")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId", "SessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("Participation");
                });

            modelBuilder.Entity("Cours", b =>
                {
                    b.Property<int>("idCours")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCours"));

                    b.Property<string>("nomCours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCours");

                    b.ToTable("cours");
                });

            modelBuilder.Entity("Formateur", b =>
                {
                    b.Property<int>("idFormateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idFormateur"));

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salaire")
                        .HasColumnType("float");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idFormateur");

                    b.ToTable("Formateurs");
                });

            modelBuilder.Entity("Formatione", b =>
                {
                    b.Property<int>("idFormation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idFormation"));

                    b.Property<int>("coursId")
                        .HasColumnType("int");

                    b.Property<string>("nomFormation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prixFormation")
                        .HasColumnType("float");

                    b.HasKey("idFormation");

                    b.HasIndex("coursId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("Participant", b =>
                {
                    b.Property<int>("idParticipant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idParticipant"));

                    b.Property<bool>("etatPayment")
                        .HasColumnType("bit");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idParticipant");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("ParticipantSession", b =>
                {
                    b.Property<int>("participantsidParticipant")
                        .HasColumnType("int");

                    b.Property<int>("sessionsidSession")
                        .HasColumnType("int");

                    b.HasKey("participantsidParticipant", "sessionsidSession");

                    b.HasIndex("sessionsidSession");

                    b.ToTable("ParticipantSession");
                });

            modelBuilder.Entity("Salle", b =>
                {
                    b.Property<int>("numSalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("numSalle"));

                    b.Property<string>("depatement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("numSalle");

                    b.ToTable("salles");
                });

            modelBuilder.Entity("Session", b =>
                {
                    b.Property<int>("idSession")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSession"));

                    b.Property<DateTime>("dateDebut")
                        .HasColumnType("datetime2");

                    b.Property<int>("duree")
                        .HasColumnType("int");

                    b.Property<int>("formateurId")
                        .HasColumnType("int");

                    b.Property<int>("formationId")
                        .HasColumnType("int");

                    b.Property<int>("salleId")
                        .HasColumnType("int");

                    b.HasKey("idSession");

                    b.HasIndex("formateurId");

                    b.HasIndex("formationId");

                    b.HasIndex("salleId");

                    b.ToTable("sessions");
                });

            modelBuilder.Entity("CentreFormation.Models.Participation", b =>
                {
                    b.HasOne("Participant", "Participant")
                        .WithMany("Participations")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session", "Session")
                        .WithMany("Participations")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("Formatione", b =>
                {
                    b.HasOne("Cours", "cours")
                        .WithMany("formations")
                        .HasForeignKey("coursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cours");
                });

            modelBuilder.Entity("ParticipantSession", b =>
                {
                    b.HasOne("Participant", null)
                        .WithMany()
                        .HasForeignKey("participantsidParticipant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session", null)
                        .WithMany()
                        .HasForeignKey("sessionsidSession")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Session", b =>
                {
                    b.HasOne("Formateur", "formateur")
                        .WithMany("sessions")
                        .HasForeignKey("formateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formatione", "formation")
                        .WithMany("sessions")
                        .HasForeignKey("formationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salle", "salle")
                        .WithMany("sessions")
                        .HasForeignKey("salleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("formateur");

                    b.Navigation("formation");

                    b.Navigation("salle");
                });

            modelBuilder.Entity("Cours", b =>
                {
                    b.Navigation("formations");
                });

            modelBuilder.Entity("Formateur", b =>
                {
                    b.Navigation("sessions");
                });

            modelBuilder.Entity("Formatione", b =>
                {
                    b.Navigation("sessions");
                });

            modelBuilder.Entity("Participant", b =>
                {
                    b.Navigation("Participations");
                });

            modelBuilder.Entity("Salle", b =>
                {
                    b.Navigation("sessions");
                });

            modelBuilder.Entity("Session", b =>
                {
                    b.Navigation("Participations");
                });
#pragma warning restore 612, 618
        }
    }
}
