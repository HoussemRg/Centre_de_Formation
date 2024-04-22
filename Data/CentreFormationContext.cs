using CentreFormation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation.Data
{
    public class CentreFormationContext:DbContext
    {
        public DbSet<Formateur> Formateurs { get; set;}
        public DbSet<Participant> Participants { get; set;}
        public DbSet<Formatione> Formations { get; set;}
        public DbSet<Salle> salles { get; set;}
        public DbSet<Cours> cours { get; set;}  
        public DbSet<Session> sessions { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=formation;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>()
                .HasKey(e => e.idSession);

            modelBuilder.Entity<Session>()
                .HasOne(e => e.salle)
                .WithMany(s => s.sessions)
                .HasForeignKey(e => e.salleId);

            modelBuilder.Entity<Session>()
                .HasOne(e => e.formateur)
                .WithMany(f => f.sessions)
                .HasForeignKey(e => e.formateurId);

            modelBuilder.Entity<Session>()
                .HasOne(e => e.formation)
                .WithMany(f => f.sessions)
                .HasForeignKey(e => e.formationId);

            modelBuilder.Entity<Participation>()
                .HasKey(p => new { p.ParticipantId, p.SessionId });

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Session)
                .WithMany(s => s.Participations)
                .HasForeignKey(p => p.SessionId);

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Participant)
                .WithMany(p => p.Participations)
                .HasForeignKey(p => p.ParticipantId);

            modelBuilder.Entity<Formatione>()
                .HasOne(f => f.cours)
                .WithMany(c => c.formations)
                .HasForeignKey(f => f.coursId);
        }
    }
}
